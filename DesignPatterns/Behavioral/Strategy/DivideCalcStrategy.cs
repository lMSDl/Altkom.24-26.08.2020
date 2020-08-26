using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class DivideCalcStrategy : ICalcStrategy
    {
        float ICalcStrategy.Calc(float value1, float value2)
        {
            return value1 / value2;
        }
    }
}
