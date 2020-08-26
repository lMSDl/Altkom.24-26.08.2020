using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public abstract class Observer<T> : IObserver<T>
    {
        private IDisposable _subscription;

        public void Subscribe(IObservable<T> observable)
        {
            if (_subscription == null)
                _subscription = observable.Subscribe(this);
        }

        public void Unsubscribe()
        {
            _subscription?.Dispose();
            _subscription = null;
        }

        public void OnCompleted()
        {
            Console.WriteLine($"{GetType().Name}: Transmisja zakończona");
            Unsubscribe();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"{GetType().Name}: Error: " + error.Message);
        }

        public abstract void OnNext(T value);
    }
}
