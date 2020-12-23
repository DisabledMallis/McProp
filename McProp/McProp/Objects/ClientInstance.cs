using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McProp.Objects
{
    class ClientInstance : GameClass
    {
        public ClientInstance() : base("ClientInstance")
        {
            this.addProp(new LocalPlayer());
        }
    }
}
