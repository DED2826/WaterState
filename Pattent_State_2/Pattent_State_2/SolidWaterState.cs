using System;
using System.Collections.Generic;
using System.Text;

namespace Pattent_State_2
{
    class SolidWaterState : IWaterState
    {
        public override void Heat1()
        {
            Console.WriteLine("-Превращаем лед в жидкость");

        }

        public override void Frost1()
        {
            Console.WriteLine("Понижаем температуру воздуха");
            this._water.TransitionTo(new GasWaterState());
        }
    }
}
