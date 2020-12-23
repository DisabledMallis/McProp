using McProp.Props;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McProp.Objects
{
    class LocalPlayer : GameClass
    {
        public LocalPlayer(GameProp parent) : base("LocalPlayer", 0x140, parent)
        {
            this.addProp(new FloatProp("stepHeight", 0x220, this));
            this.addProp(new FloatProp("speed", 0x32C, this));
            this.addProp(new FloatProp("distanceTraveled", 0x334, this));
            this.addProp(new FloatProp("positionX_a", 0x498, this));
            this.addProp(new FloatProp("positionY_a", 0x49C, this));
            this.addProp(new FloatProp("positionZ_a", 0x4A0, this));
            this.addProp(new FloatProp("positionX_b", 0x4A4, this));
            this.addProp(new FloatProp("positionY_b", 0x4A8, this));
            this.addProp(new FloatProp("positionZ_b", 0x4AC, this));
            this.addProp(new FloatProp("hitboxWidth", 0x4B4, this));
            this.addProp(new FloatProp("hitboxHeight", 0x4B8, this));
            this.addProp(new FloatProp("positionX_c", 0x4BC, this));
            this.addProp(new FloatProp("positionY_c", 0x4C0, this));
            this.addProp(new FloatProp("positionZ_c", 0x4C4, this));
            this.addProp(new FloatProp("velocityX", 0x4D4, this));
            this.addProp(new FloatProp("velocityY", 0x4D8, this));
            this.addProp(new FloatProp("velocityZ", 0x4DC, this));
        }
    }
}
