using McProp.Objects;
using Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McProp
{
    class GameProp : TreeNode
    {
        private string propName = "";
        private int offset = 0;
        private GameProp parent;
        public GameProp(string propName, int offset, GameProp parent)
        {
            this.propName = propName;
            this.offset = offset;
            this.parent = parent;
            this.Text = this.ToString();
        }
        

        public string getName()
        {
            return this.propName;
        }
        public int getOffset()
        {
            return this.offset;
        }
        public GameProp getParent()
        {
            return this.parent;
        }
        public virtual string getType()
        {
            return "long";
        }

        public virtual ulong getAddress()
        {
            Mem memLib = Program.getMem();
            List<int> offsets = new List<int>();
            offsets.Add(this.getOffset());
            GameProp nextParent = parent;
            GameProp lastParent = this;
            while (nextParent != null && !(nextParent is ClientInstance))
            {
                offsets.Add(nextParent.getOffset());
                lastParent = nextParent;
                nextParent = nextParent.getParent();
            }
            offsets.Reverse();
            ulong theAddress = nextParent.getAddress();
            int i = 0;
            foreach (int offset in offsets)
            {
                i++;
                if(offsets.Count == i)
                {
                    ulong thePtr = theAddress + (ulong)offset;
                    theAddress = (ulong)memLib.ReadLong(thePtr.ToString("X"));
                }
            }
            return theAddress;
        }
        public virtual ulong getData()
        {
            Mem memLib = Program.getMem();
            ulong value = (ulong)memLib.ReadLong(getAddress().ToString("X"));
            return value;
        }

        public virtual string getValueString()
        {
            return this.getData().ToString("X");
        }

        public override string ToString()
        {
            return this.getName() + " - " + this.getValueString() + " - 0x" + this.getOffset().ToString("X");
        }
    }
}
