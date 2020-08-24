using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Client
    {
        public static void Execute()
        {
            Order order;

            order = new Order(new HondaFactory(), "compact", nameof(ISedan));
            Console.WriteLine(order.ManufacturedCarName());


            order = new Order(new ToyotaFactory(), "compact", nameof(ISedan));
            Console.WriteLine(order.ManufacturedCarName());


            order = new Order(new ToyotaFactory(), "full", nameof(ISuv));
            Console.WriteLine(order.ManufacturedCarName());

        }
    }
}
