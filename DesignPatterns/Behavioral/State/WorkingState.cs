using System;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class WorkingState : State
    {
        private CancellationTokenSource _cancellationTokenSource;
        private int _time;

        public WorkingState(int time)
        {
            _time = time;

        }

        public override void LargeCoffee()
        {
            _cancellationTokenSource.Cancel();
            Console.WriteLine("WorkingState: process cancelled");
        }

        public override void SmallCoffee()
        {
            _cancellationTokenSource.Cancel();
            Console.WriteLine("WorkingState: process cancelled");
        }

        protected override void OnNewContext()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            Task task = Task.Delay(TimeSpan.FromSeconds(_time), _cancellationTokenSource.Token);
            task.ContinueWith(x =>
            {
                CoffeeMachine.TransitionTo(new IdleState());
                _cancellationTokenSource.Dispose();
            });
        }
    }
}
