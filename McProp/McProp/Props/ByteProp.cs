using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McProp.Props
{
    class ByteProp : GameProp
    {
        public ByteProp(string propName, int offset, GameProp parent) : base(propName, offset, parent)
        {

        }
        public override string ToString()
        {
            return this.getName() + " - 0x" + BitConverter.GetBytes(this.getData())[0].ToString("X") + " - 0x" + this.getOffset().ToString("X");
        }
    }
}
