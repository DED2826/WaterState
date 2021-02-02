using System;
using System.Collections.Generic;
using System.Text;

namespace Pattent_State_2
{
    class GasWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Повышаем температуру ");
            water.State = new LiquidWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("-Превращаем водяной пар в жидкость");
            if (this.GetType().Name == "GasWaterState")
            {
                Console.WriteLine("Понижаем температуру");
                water.State = new LiquidWaterState();
            }
        }
    }
}
