using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public interface IContainerOperations
    {
        void Add(ProductBase product);
        void Remove(ProductBase product);
    }
}
