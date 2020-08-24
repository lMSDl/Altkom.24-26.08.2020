using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class VehicleBuilder : VehicleBuilderFacade
    {
        public VehicleBuilder()
        {
        }

        public VehicleBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleBuilder SetWheels(int wheels)
        {
            Vehicle.Wheels = wheels;
            return this;
        }


        public VehicleBuilder SetSeats(int seats)
        {
            Vehicle.Seats = seats;
            return this;
        }


        public VehicleBuilder SetDoors(int doors)
        {
            Vehicle.Doors = doors;
            return this;
        }


        public VehicleBuilder SetTrunkCapacity(int? trunkCapacity)
        {
            Vehicle.TrunkCapacity = trunkCapacity;
            return this;
        }

        public VehicleBuilder SetEnginePower(int? enginePower)
        {
            Vehicle.EnginePower = enginePower;
            return this;
        }
    }
}
