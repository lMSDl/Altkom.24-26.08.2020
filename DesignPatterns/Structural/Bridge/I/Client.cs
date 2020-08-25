using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.I
{
    public class Client
    {
        public static void Execute()
        {
            var shape = new Circle();
            var color = new RedColor();
            shape.Color = color;

            Console.WriteLine(shape);

            Console.WriteLine(new Square() {Color = new BlueColor() {Brightness = new LightBrightness() } });
        }
    }
}
