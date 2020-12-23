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
        }
    }
}
