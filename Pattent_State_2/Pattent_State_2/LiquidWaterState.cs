using System;
using System.Collections.Generic;
using System.Text;

namespace Pattent_State_2
{
    class LiquidWaterState : IWaterState
    {
        public override void Heat1()
        {
            Console.WriteLine("-Превращаем жидкость в пар");
            this._water.TransitionTo(new SolidWaterState());
        }

        public override void Frost1()
        {
            Console.WriteLine("-Превращаем жидкость в лед");
            if (this.GetType().Name == "LiquidWaterState")
            {
                Console.WriteLine("Повышаем температуру");
                this._water.TransitionTo(new SolidWaterState());
            }

        }
    }
}
