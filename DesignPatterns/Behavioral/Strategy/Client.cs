using DesignPatterns.Behavioral.ChainOfResponsibility.I;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Creational.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class Client
    {
        public static void Execute()
        {
            var calc = new Calculator();

            while(true)
            {
                var line = Console.ReadLine();

                var split = line.Split(' ');
                if (split.Length < 3)
                    continue;

                calc.Strategy = GetCalcStrategy(split[1]);


                if(float.TryParse(split[0], out float val1) &&
                    float.TryParse(split[2], out float val2))
                {
                    var result = calc.Operate(val1, val2);
                    Console.WriteLine(  calc.Operate(val1, val2, GetCalcFunc(split[1])));
                    Console.WriteLine(result);
                }

            }
        }
        private static ICalcStrategy GetCalcStrategy(string arg)
        {
            switch(arg)
            {
                case "*":
                    return new MultiplyCalcStrategy();
                case "/":
                    return new DivideCalcStrategy();
                case "+":
                    return new PlusCalcStrategy();
                case "-":
                    return new MinusCalcStrategy();
                default:
                    return null;
            }
        }

        private static Func<float, float, float> GetCalcFunc(string arg)
        {
            switch (arg)
            {
                case "*":
                    return (a, b) => a * b;
                case "/":
                    return (a, b) => a / b;
                case "+":
                    return (a, b) => a + b;
                case "-":
                    return (a, b) => a - b;
                default:
                    return null;
            }
        }
    }
}
