using System;
using System.Collections.Generic;
using System.Text;

namespace Pattent_State_2
{
    class Water
    {
        private IWaterState _state = null;

        public Water(IWaterState state)
        {
            this.TransitionTo(state);
        }
        public void TransitionTo(IWaterState state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            this._state = state;
            this._state.SetContext(this);
        }

        public void Heat()
        {
            this._state.Heat1();
        }

        public void Frost()
        {
            this._state.Frost1();
        }
    }
}
