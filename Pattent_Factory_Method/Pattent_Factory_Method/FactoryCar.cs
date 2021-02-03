using System;
using System.Collections.Generic;
using System.Text;

namespace Pattent_Factory_Method
{
    class FactoryCar : Factory
    {
        public FactoryCar(string n) : base(n)
        { }

        public override Car Create()
        {
            return new Toyota();
        }
    }

    class FactoryCar1 : Factory
    {
        public FactoryCar1(string n) : base(n)
        { }

        public override Car Create()
        {
            return new Mers();
        }
    }
}
