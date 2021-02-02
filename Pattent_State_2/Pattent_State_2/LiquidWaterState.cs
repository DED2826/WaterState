using System;
using System.Collections.Generic;
using System.Text;

namespace Pattent_State_2
{
    class LiquidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("-Превращаем жидкость в пар");
            water.State = new SolidWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("-Превращаем жидкость в лед");
            if (this.GetType().Name == "LiquidWaterState")
            {
                Console.WriteLine("Повышаем температуру");
                water.State = new SolidWaterState();
            }

        }
    }
}
