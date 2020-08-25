using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public abstract class ProductBase
    {
        public string Name { get; }
        public float Price { get; }

        protected ProductBase(string name, float price)
        {
            Name = name;
            Price = price;
        }

        public abstract float CalculateTotalPrice();
    }
}
