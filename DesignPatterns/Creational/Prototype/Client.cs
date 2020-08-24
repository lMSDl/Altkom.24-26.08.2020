using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public class Client
    {
        public static void Execute()
        {
            var p1 = new Person
            {
                Age = 23,
                Name = "Adam Adamski",
                IdInfo = new IdInfo()
            };

            var p2 = (Person)p1.Clone();
            p2.Name = "Ewa Ewowska";
            Display(p1);
            Display(p2);

            p2.IdInfo.IdNumber = Guid.NewGuid();
            Display(p1);
            Display(p2);
        }

        public static void Display(Person person)
        {
            Console.WriteLine($"Name: {person.Name}, Age {person.Age}");
            Console.WriteLine($"ID: {person.IdInfo.IdNumber}");
        }
    }
}
