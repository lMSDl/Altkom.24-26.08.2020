using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    public class DiscountHandler : BaseHandler
    {
        private float MaxDiscount { get; }
        private float MinPrice { get; }
        public string Name { get; set; }

        public DiscountHandler(float maxDiscount, float maxPrice, IHandler nextHandler) : base(nextHandler)
        {
            MaxDiscount = maxDiscount;
            MinPrice = maxPrice;
        }

        public DiscountHandler(float maxDiscount, float maxPrice) : this(maxDiscount, maxPrice, null)
        {
        }

        public override bool Discount(float value, float price)
        {
            if (MaxDiscount > value && price >= MinPrice)
            {
                Console.WriteLine($"Discount accepted by handler {Name}");
                return true;
            }
            return NextHandler?.Discount(value, price) ?? false;
        }
    }
}
