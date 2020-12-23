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
            this.addProp(new GameProp("stepHeight", 0x220, this));
            this.addProp(new GameProp("speed", 0x32C, this));
            this.addProp(new GameProp("positionX_a", 0x480, this));
            this.addProp(new GameProp("positionY_a", 0x484, this));
            this.addProp(new GameProp("positionZ_a", 0x488, this));
            this.addProp(new GameProp("positionX_b", 0x48C, this));
            this.addProp(new GameProp("positionY_b", 0x490, this));
            this.addProp(new GameProp("positionZ_b", 0x494, this));
            this.addProp(new GameProp("hitboxWidth", 0x49C, this));
            this.addProp(new GameProp("hitboxHeight", 0x4A0, this));
            this.addProp(new GameProp("positionX_c", 0x4A4, this));
            this.addProp(new GameProp("positionY_c", 0x4A8, this));
            this.addProp(new GameProp("positionZ_c", 0x4AC, this));
            this.addProp(new GameProp("velocityX", 0x4BC, this));
            this.addProp(new GameProp("velocityY", 0x4C0, this));
            this.addProp(new GameProp("velocityZ", 0x4C4, this));
        }
    }
}
