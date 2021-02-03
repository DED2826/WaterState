using System;
using System.Collections.Generic;
using System.Text;

namespace Pattent_Factory_Method
{
    class FactoryEngine1 : Factory
    {
        public FactoryEngine1(string n) : base(n)
        { }

        public override Car Create()
        {
            return new eng24();
        }
    }

    class FactoryEngine2 : Factory
    {
        public FactoryEngine2(string n) : base(n)
        { }

        public override Car Create()
        {
            return new eng30();
        }
    }

    class FactoryEngine3 : Factory
    {
        public FactoryEngine3(string n) : base(n)
        { }

        public override Car Create()
        {
            return new eng20();
        }
    }
}
