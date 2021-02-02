using System;
using System.Collections.Generic;
using System.Text;

namespace Pattent_State_2
{
    class SolidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("-Превращаем лед в жидкость");

        }

        public void Frost(Water water)
        {
            Console.WriteLine("Понижаем температуру воздуха");
            water.State = new GasWaterState();
        }
    }
}
