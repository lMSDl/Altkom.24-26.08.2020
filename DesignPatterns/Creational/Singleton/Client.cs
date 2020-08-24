using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class Client
    {
        public static void Execute()
        {
            var db1 = Context.Instance.GetSettings("1");
            Console.WriteLine($"Service: {db1}");
            var db2 = Context.Instance.GetSettings("2");
            Console.WriteLine($"Service: {db2}");
        }
    }
}
