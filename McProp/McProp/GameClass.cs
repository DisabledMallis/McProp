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
        private List<GameProp> properties;
        public GameClass(string className, GameProp parent) : this(className, 0, parent) { }
        public GameClass(string className, int offset, GameProp parent) : base(className, offset, parent)
        {
            properties = new List<GameProp>();
        }
        public void addProp(GameProp toAdd)
        {
            properties.Add(toAdd);
        }

        public override TreeNode toNode()
        {
            TreeNode node = base.toNode();
            foreach(GameProp gameProp in properties)
            {
                node.Nodes.Add(gameProp.toNode());
            }
            return node;
        }
    }
}
