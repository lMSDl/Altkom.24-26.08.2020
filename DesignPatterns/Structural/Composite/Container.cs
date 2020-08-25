using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Container : ProductBase, IContainerOperations
    {
        private List<ProductBase> _content;

        public Container(string name, float price) : base(name, price)
        {
            _content = new List<ProductBase>();
        }

        public void Add(ProductBase product)
        {
            _content.Add(product);
        }
        public void Remove(ProductBase product)
        {
            _content.Remove(product);
        }

        public override float CalculateTotalPrice()
        {
            float total = 0;

            Console.WriteLine($"{Name} zawiera produkty o następującej cenie:");

            foreach (var item in _content)
            {
                total += item.CalculateTotalPrice();
            }

            return total;
        }

    }
}
