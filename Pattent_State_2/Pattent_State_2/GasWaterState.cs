using System;
using System.Collections.Generic;
using System.Text;

namespace Pattent_State_2
{
    class GasWaterState : IWaterState
    {
        public override void Heat1()
        {
            Console.WriteLine("Повышаем температуру ");
            this._water.TransitionTo(new LiquidWaterState());
        }

        public override void Frost1()
        {
            Console.WriteLine("-Превращаем водяной пар в жидкость");
            if (this.GetType().Name == "GasWaterState")
            {
                Console.WriteLine("Понижаем температуру");
                this._water.TransitionTo(new LiquidWaterState());
            }
        }
    }
}
