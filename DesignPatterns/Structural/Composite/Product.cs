using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Product : ProductBase, ICloneable
    {
        public Product(string name, float price) : base(name, price)
        {
        }

        public override float CalculateTotalPrice()
        {
            Console.WriteLine($"{Name} jest w cenie {Price}");
            return Price;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
