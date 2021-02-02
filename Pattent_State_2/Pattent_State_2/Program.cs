using System;

namespace Pattent_State_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Water water = new Water(new GasWaterState());
            water.Heat();
            water.Heat();
            water.Frost();
            water.Frost();
            water.Frost();
            water.Heat();


            Console.Read();
        }
    }
}
