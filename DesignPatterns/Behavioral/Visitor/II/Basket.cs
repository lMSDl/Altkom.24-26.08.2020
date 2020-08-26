﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.II
{
    public class Basket : IVisitor
    {
        public void Visit(Product product)
        {
            Add(product);
        }

        public void Visit(BoxedProduct product)
        {
            Add(product);
        }

        public virtual void Add(Product product)
        {
            Console.WriteLine("Produkt w koszyku");
        }
        public virtual void Add(BoxedProduct product)
        {
            Console.WriteLine("Całe opakowanie produktu jest za duże");
        }
    }
}
