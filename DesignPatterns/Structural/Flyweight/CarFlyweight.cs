using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class CarFlyweight : ICarFlyweight
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public void Operation(Car uniqueState)
        {
            var shared = JsonConvert.SerializeObject(this);
            var unique = JsonConvert.SerializeObject(uniqueState);

            Console.WriteLine($"{GetType().Name}: Shared: {shared}; Unique: {unique}");
        }
    }
}
