using System;
using System.Collections.Generic;
using System.Text;

namespace Pattent_Factory_Method
{
    class Car
    {
    }

    //Марка
    class Toyota : Car
    {
        public Toyota()
        {
            Console.Write("Toyota ");
        }
    }

    class Mers : Car
    {
        public Mers()
        {
            Console.Write("Mersedes-Bens ");
        }
    }


    //Модель
    class Camry30 : Car
    {
        public Camry30()
        {
            Console.Write("Camry 30 ");
        }
    }

    class Camry40 : Car
    {
        public Camry40()
        {
            Console.Write("Camry 40 ");
        }
    }

    class SLK : Car
    {
        public SLK()
        {
            Console.Write("SLK ");
        }
    }


    //Двигатель
    class eng20 : Car
    {
        public eng20()
        {
            Console.Write("Двиг. 2.0 ");
        }
    }
    class eng24 : Car
    {
        public eng24()
        {
            Console.Write("Двиг. 2.4 ");
        }
    }

    class eng30 : Car
    {
        public eng30()
        {
            Console.Write("Двиг. 3.0 ");
        }
    }


    //Комплектация
    class Camrylux : Car
    {
        public Camrylux()
        {
            Console.Write("Lux ");
        }
    }

    class Camrystandart : Car
    {
        public Camrystandart()
        {
            Console.Write("Standart ");
        }
    }
}
