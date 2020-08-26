using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
   public  class Calculator
    {
        public ICalcStrategy Strategy { get; set; }

        public float? Operate(float value1, float value2)
        {
            return Strategy?.Calc(value1, value2);
        }


        public float? Operate(float value1, float value2, Func<float, float, float> func)
        {
            return func?.Invoke(value1, value2);
        }
    }
}
