using SOLID.III_LS_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            DesignPatterns.Creational.FactoryMethod.Client.Execute();



            //var a = 2;
            //var b = 5;

            //Square square = new Rectangle() { A = a, B = b };

            //Console.WriteLine($"Prostokąt o bokach: {a} i {b}, ma pole równe {square.Area}");

            Console.ReadLine();
        }
    }
}
