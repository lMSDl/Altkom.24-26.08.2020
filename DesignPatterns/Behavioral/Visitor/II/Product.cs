using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.II
{
    public class Product : IElement
    {
        public virtual void PrintType()
        {
            Console.WriteLine("Product");
        }

        public virtual void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
