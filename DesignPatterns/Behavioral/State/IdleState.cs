using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class IdleState : State
    {
        public override void LargeCoffee()
        {
            Console.WriteLine("IdleState: make large coffee");
            CoffeeMachine.TransitionTo(new WorkingState(8));
        }

        public override void SmallCoffee()
        {
            Console.WriteLine("IdleState: make small coffee");
            CoffeeMachine.TransitionTo(new WorkingState(5));
        }

        protected override void OnNewContext()
        {
        }
    }
}
