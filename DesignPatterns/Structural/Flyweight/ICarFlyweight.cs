using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public interface ICarFlyweight
    {
        string Manufacturer { get; set; }
        string Model { get; set; }
        string Color { get; set; }
    }
}
