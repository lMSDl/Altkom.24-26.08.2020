using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class Subject : IObservable<int>, IDisposable
    {
        private List<IObserver<int>> _observers = new List<IObserver<int>>();
        private int index;

        public int Index { get => index; set { index = value;  Notify(); } }

        public IDisposable Subscribe(IObserver<int> observer)
        {
            if (_observers == null)
                return null;
            _observers.Add(observer);
            return new Unsubscriber<int>(_observers, observer);
        }

        public void Work()
        {
            Console.WriteLine("Subject: Robię bardzo ważne obliczenia");
            Index = new Random().Next(-1, 10);
            Thread.Sleep(15);
            Console.WriteLine($"Subject: Mój stan zmienił się na {Index}");
        }

        public void Notify()
        {
            if (Index < 0)
                _observers.ToList().ForEach(x => x.OnError(new IndexOutOfRangeException()));
            else
                _observers.ToList().ForEach(x => x.OnNext(Index));
        }

        public void Dispose()
        {
            var observers = _observers.ToList();
            _observers = null;
            observers.ForEach(x => x.OnCompleted());
        }
    }
}
