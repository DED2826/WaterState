using System;
using System.Collections.Generic;
using System.Text;

namespace Pattent_Factory_Method
{
    class FactoriyEquipmentcs1 : Factory
    {
        public FactoriyEquipmentcs1(string n) : base(n)
        { }

        public override Car Create()
        {
            return new Camrylux();
        }
    }

    class FactoriyEquipmentcs2 : Factory
    {
        public FactoriyEquipmentcs2(string n) : base(n)
        { }

        public override Car Create()
        {
            return new Camrystandart();
        }
    }
}
