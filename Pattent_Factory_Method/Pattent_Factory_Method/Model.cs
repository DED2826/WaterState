using System;
using System.Collections.Generic;
using System.Text;

namespace Pattent_Factory_Method
{
    class Model1 : Factory
    {
        public Model1(string n) : base(n)
        { }

        public override Car Create()
        {
            return new Camry30();
        }
    }

    class Model2 : Factory
    {
        public Model2(string n) : base(n)
        { }

        public override Car Create()
        {
            return new Camry40();
        }
    }

    class Model3 : Factory
    {
        public Model3(string n) : base(n)
        { }

        public override Car Create()
        {
            return new SLK();
        }
    }
}
