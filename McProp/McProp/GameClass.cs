using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McProp
{
    class GameClass : GameProp
    {
        public GameClass(string className, GameProp parent) : this(className, 0, parent) { }
        public GameClass(string className, int offset, GameProp parent) : base(className, offset, parent) { }
        public void addProp(GameProp toAdd)
        {
            this.Nodes.Add(toAdd);
        }
        public override string getValueString()
        {
            return this.getAddress().ToString("X");
        }
    }
}
