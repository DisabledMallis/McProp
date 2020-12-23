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
        public override string getType()
        {
            return "float";
        }
        public override string getValueString()
        {
            return BitConverter.ToSingle(BitConverter.GetBytes(this.getAddress()), 0).ToString();
        }
    }
}
