using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    abstract class Vehicle
    {
        public string Name { get; set; }
        public abstract void Move();
    }

    class Airplain : Vehicle
    {
        public void Fly()
        {
            Console.WriteLine("LECĘ!");
        }

        public override void Move()
        {
            Fly();
        }
    }

    class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("JADĘ!");
        }

        public override void Move()
        {
            Drive();
        }
    }
}
