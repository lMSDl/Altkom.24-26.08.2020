using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class Client
    {
        public static void Execute()
        {
            var elevator = new Elevator();

            var command = elevator.CreateAction(ElevatorActions.Up.ToString());
            elevator.Execute(command, 3);

            command = elevator.CreateAction("GoTo");
            elevator.Execute(command, 5);

        }
    }
}
