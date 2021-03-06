﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McProp.Objects
{
    class ClientInstance : GameClass
    {
        ulong address = 0;
        public ClientInstance(ulong address) : base("ClientInstance", 0, null)
        {
            this.address = address;
            this.addProp(new LocalPlayer(this));
        }

        public override string getValueString()
        {
            return this.getAddress().ToString("X");
        }

        public override ulong getAddress()
        {
            return this.address;
        }
    }
}
