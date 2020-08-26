using DesignPatterns.Behavioral.ChainOfResponsibility.I;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Creational.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public class Client
    {
        public static void Execute()
        {
            var person = new Person()
            {
                Name = "Adam Adamski",
                BirthDate = new DateTime(1989, 12, 12)
            };

            var caretaker = new Caretaker<Person>(person);
            Console.WriteLine($"Name: {person.Name}");
            caretaker.Save();

            person.Name = "Ewa Adamska";
            Console.WriteLine($"Name: {person.Name}");
            caretaker.Save();

            person.Name = "Ewa Ewowska";
            Console.WriteLine($"Name: {person.Name}");

            while(true)
            caretaker.Save();

            caretaker.Undo();
            Console.WriteLine($"Name: {person.Name}");
            caretaker.Undo();
            Console.WriteLine($"Name: {person.Name}");
            caretaker.Undo();
            Console.WriteLine($"Name: {person.Name}");
        }
    }
}
