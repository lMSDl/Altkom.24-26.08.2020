using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class Elevator
    {
        private readonly Dictionary<string, IElevatorOperation> _commands;

        public Elevator()
        {
            var type = typeof(IElevatorOperation);
            _commands = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => !x.IsInterface)
                .Where(x => type.IsAssignableFrom(x))
                .Select(x => (IElevatorOperation)Activator.CreateInstance(x))
                .ToDictionary(x => x.GetType().Name);

            //_commands = new Dictionary<string, IElevatorOperation>
            //{
            //    { nameof(ElevatorDown), new ElevatorDown() },
            //    { nameof(ElevatorUp), new ElevatorUp() },
            //    { nameof(ElevatorGoTo), new ElevatorGoTo()}
            //};
        }

        public virtual IElevatorOperation CreateAction(string action)
        {
            return _commands[nameof(Elevator) + action];

            //switch (nameof(Elevator) + action)
            //{
            //    case nameof(ElevatorDown):
            //        return new ElevatorDown();
            //    case nameof(ElevatorUp):
            //        return new ElevatorUp();
            //}
            //return null;
        }

        public void Execute(IElevatorOperation command, int floor)
        {
            command?.Operate(floor);
        }
    }
}
