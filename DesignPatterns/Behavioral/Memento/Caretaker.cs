using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public class Caretaker<T> where T : ICloneable, IRestorable<T>
    {
        private Stack<IMemento<T>> _history = new Stack<IMemento<T>>();
        private T _originator;

        public Caretaker(T originator)
        {
            _originator = originator;
        }

        public void Save()
        {
            Console.WriteLine("Zapisywanie stanu");
            _history.Push(new Memento<T>((T)_originator.Clone()));
        }

        public void Undo()
        {
            if (!_history.Any())
                return;

            var memento = _history.Pop();
            Console.WriteLine($"Przywracanie stanu z {memento.DateTime:U}");
            _originator.Restore(memento.State);
        }

        public void ShowHistory()
        {
            Console.WriteLine("Posiadam migawki z dat:");
            _history.ToList().ForEach(x => Console.WriteLine($"{x.DateTime:U}"));
        }
    }
}
