using System;

namespace Pattern_State
{
    class Program
    {
        static void Main(string[] args)
        {
            Water water = new Water(WaterState.LIQUID);
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
