using System;
using System.Collections.Generic;
using System.Text;

namespace Pattent_State_2
{
    abstract class IWaterState
    {
        protected Water _water;

        public void SetContext(Water water)
        {
            this._water = water;
        }

        public abstract void Heat1();

        public abstract void Frost1();
    }
}
