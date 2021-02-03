using System;
using System.Collections.Generic;
using System.Text;

namespace Pattent_Factory_Method
{
    abstract class Factory
    {
        public string Name { get; set; }

        public Factory(string n)
        {
            Name = n;
        }
        abstract public Car Create();
    }
}
