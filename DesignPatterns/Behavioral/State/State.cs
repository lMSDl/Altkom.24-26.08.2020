using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public abstract class State : IState
    {
        private CoffeeMachine coffeeMachine;

        public CoffeeMachine CoffeeMachine { protected get => coffeeMachine; set { coffeeMachine = value; OnNewContext(); } }

        protected abstract void OnNewContext();
        public abstract void SmallCoffee();
        public abstract void LargeCoffee();

    }
}
