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
    class GameProp
    {
        private string propName = "";
        private int offset = 0;
        private GameProp parent;
        public GameProp(string propName, int offset, GameProp parent)
        {
            this.propName = propName;
            this.offset = offset;
            this.parent = parent;
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

        public virtual TreeNode toNode()
        {
            TreeNode node = new TreeNode();
            node.Text = this.getName() + " - 0x" + this.getData() + " - 0x" + this.getOffset().ToString("X");
            return node;
        }

        public virtual ulong getData()
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
            ulong theAddress = nextParent.getData();
            foreach(int offset in offsets)
            {
                ulong thePtr = theAddress + (ulong)offset;
                theAddress = (ulong)memLib.ReadLong(thePtr.ToString("X"));
            }
            return theAddress;
        }
    }
}
