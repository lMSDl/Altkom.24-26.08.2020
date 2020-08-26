using DesignPatterns.Behavioral.ChainOfResponsibility.I;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Creational.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class Client
    {
        public static void Execute()
        {
            using (var subject = new Subject())
            {
                var observerA = new ObserverA();
                var observerB = new ObserverB();

                observerA.Subscribe(subject);
                observerB.Subscribe(subject);
                //subject.Subscribe(observerA);
                //subject.Subscribe(observerB);

                subject.Work();
                subject.Work();

                subject.Work();

                Console.WriteLine("Ręczna zmiana stanu");
                subject.Index = 1;
            }
        }
    }
}
