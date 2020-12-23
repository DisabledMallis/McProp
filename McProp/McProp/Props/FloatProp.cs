using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McProp.Props
{
    class FloatProp : GameProp
    {
        public FloatProp(string propName, int offset, GameProp parent) : base(propName, offset, parent)
        {

        }
        public override string ToString()
        {
            return this.getName() + " - " + BitConverter.ToSingle(BitConverter.GetBytes(this.getData()), 0) + " - 0x" + this.getOffset().ToString("X");
        }
    }
}
