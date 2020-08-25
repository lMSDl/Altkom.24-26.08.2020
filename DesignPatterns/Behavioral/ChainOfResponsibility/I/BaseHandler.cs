using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    public abstract class BaseHandler : IHandler
    {
        protected IHandler NextHandler { get; }

        protected BaseHandler(IHandler nextHandler)
        {
            NextHandler = nextHandler;
        }

        public abstract bool Discount(float value, float price);
    }
}
