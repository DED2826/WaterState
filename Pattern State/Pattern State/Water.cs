using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_State
{
    enum WaterState
    {
        SOLID,
        LIQUID,
        GAS
    }
    class Water
    {
        public WaterState State { get; set; }

        public Water(WaterState ws)
        {
            State = ws;
        }

        public void Heat()
        {
            if (State == WaterState.SOLID)
            {
                Console.WriteLine("Повышаем температуру");
                Console.WriteLine("-Превращаем лед в жидкость");
                State = WaterState.LIQUID;
            }
            else if (State == WaterState.LIQUID)
            {
                Console.WriteLine("Повышаем температуру");
                Console.WriteLine("-Превращаем жидкость в пар");
                State = WaterState.GAS;
            }
            else if (State == WaterState.GAS)
            {
                Console.WriteLine("Понижаем температуру");
            }

        }
        public void Frost()
        {
            if (State == WaterState.SOLID)
            {
                Console.WriteLine("-Превращаем жидкость в лед");
                State = WaterState.SOLID;
            }
            else if (State == WaterState.GAS)
            {
                Console.WriteLine("-Превращаем водяной пар в жидкость");
                State = WaterState.LIQUID;
            }
            else if (State == WaterState.LIQUID)
            {
                Console.WriteLine("Понижаем температуру");
                State = WaterState.SOLID;
            }
        }
    }
}