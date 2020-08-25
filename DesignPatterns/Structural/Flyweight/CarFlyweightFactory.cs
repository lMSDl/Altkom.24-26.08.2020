using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class CarFlyweightFactory
    {
        private readonly Dictionary<string, CarFlyweight> _flyweights;

        public CarFlyweightFactory(IEnumerable<CarFlyweight> flyweights)
        {
            _flyweights = flyweights.ToDictionary(x => GetKey(x));
        }

        public string GetKey(CarFlyweight flyweight)
        {
            var elements = new List<string>
            {
                flyweight.Manufacturer,
                flyweight.Model,
                flyweight.Color
            };

            return string.Join("_", elements);
        }

        public CarFlyweight GetFlyweight(CarFlyweight flyweight)
        {
            var key = GetKey(flyweight);

            if(_flyweights.ContainsKey(key))
            {
                Console.WriteLine($"{GetType().Name}: Używamy istniejącego elementu");
                return _flyweights[key];
            }

            Console.WriteLine($"{GetType().Name}: Tworzymy nowy element");
            _flyweights.Add(key, flyweight);
            return flyweight;
        }

        public void ListFlyweights()
        {
            Console.WriteLine($"{GetType().Name}: W fabryce posiadamy {_flyweights.Count} elementów:");
            _flyweights.ToList().ForEach(x => Console.WriteLine(x.Key));
        }
    }
}
