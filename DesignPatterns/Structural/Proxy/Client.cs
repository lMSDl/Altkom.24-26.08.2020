using DesignPatterns.Structural.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class Client
    {
        public static void Execute()
        {
            var database = new Database();
            var proxy = new DatabaseProxy();

            for (int i = 1; i < 11; i++)
            {
                _ = proxy.RequestAsync(i);
            }

            Console.ReadKey();

            for (int i = 1; i < 11; i++)
            {
                _ = proxy.RequestAsync(i);
            }
        }
    }
}
