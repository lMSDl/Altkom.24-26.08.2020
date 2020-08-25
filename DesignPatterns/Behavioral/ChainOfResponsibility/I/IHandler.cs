using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    public interface IHandler
    {
        bool Discount(float value, float price);
    }
}
