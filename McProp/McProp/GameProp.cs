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
        string propName = "";
        int offset = 0;
        public GameProp(string propName, int offset)
        {
            this.propName = propName;
            this.offset = offset;
        }
        

        public string getName()
        {
            return this.propName;
        }
        public int getOffset()
        {
            return this.offset;
        }

        public virtual TreeNode toNode()
        {
            TreeNode node = new TreeNode();
            node.Text = this.getName();
            return node;
        }
    }
}
