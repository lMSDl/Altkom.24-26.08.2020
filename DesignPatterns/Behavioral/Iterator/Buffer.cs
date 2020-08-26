using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class Buffer<T> : IEnumerable<T[]>
    {
        private IEnumerable<T> _enumetable;

        public Buffer(IEnumerable<T> enumetable)
        {
            _enumetable = enumetable;
        }

        public IEnumerator<T[]> GetEnumerator()
        {
            return new BufferIterator<T>(_enumetable);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
