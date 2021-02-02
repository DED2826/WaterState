using System;
using System.Collections.Generic;
using System.Text;

namespace Pattent_State_2
{
    interface IWaterState
    {
        void Heat(Water water);
        void Frost(Water water);
    }
}
