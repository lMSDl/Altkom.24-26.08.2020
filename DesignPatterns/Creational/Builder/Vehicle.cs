using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Vehicle : ManufacturingInfo
    {

        public Vehicle()
        {

        }

        //public Vehicle(int wheels, int seats)
        //{
        //    Wheels = wheels;
        //    Seats = seats;
        //}

        //public Vehicle(int wheels, int seats, int doors) : this(wheels, seats)
        //{
        //    Doors = doors;
        //}
        //public Vehicle(int wheels, int seats, int? trunkCapacity) : this(wheels, seats)
        //{
        //    TrunkCapacity = trunkCapacity;
        //}
        //public Vehicle(int wheels, int? enginePower, int seats) : this(wheels, seats)
        //{
        //    EnginePower = enginePower;
        //}

        //public Vehicle(int wheels, int seats, int doors, int? trunkCapacity, int? enginePower) : this(wheels, seats, doors)
        //{
        //    TrunkCapacity = trunkCapacity;
        //    EnginePower = enginePower;
        //}

        public int Wheels { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }
        public int? TrunkCapacity { get; set; }
        public int? EnginePower { get; set; }

        public override string ToString()
        {
            return $"Obiekt ma {Wheels} kół, {Seats} siedzeń, {Doors} drzwi" + (TrunkCapacity.HasValue ? $", pojemność bagażnika {TrunkCapacity}" : "") + (EnginePower.HasValue ? $", moc silnika {EnginePower}HP" : "");
        }

        //public class VehicleBuilder
        //{
        //    private Vehicle _vehicle;

        //    public VehicleBuilder(Vehicle vehicle)
        //    {
        //        _vehicle = vehicle;
        //    }

        //    public VehicleBuilder()
        //    {
        //        _vehicle = new Vehicle();
        //    }

        //    public Vehicle Buiild()
        //    {
        //        return _vehicle;
        //    }

        //    public void SetWheels(int wheels)
        //    {
        //        _vehicle.Wheels = wheels;
        //    }


        //    public void SetSeats(int seats)
        //    {
        //        _vehicle.Seats = seats;
        //    }


        //    public void SetDoors(int doors)
        //    {
        //        _vehicle.Doors = doors;
        //    }


        //    public void SetTrunkCapacity(int? trunkCapacity)
        //    {
        //        _vehicle.TrunkCapacity = trunkCapacity;
        //    }

        //    public void SetEnginePower(int? enginePower)
        //    {
        //        _vehicle.EnginePower = enginePower;
        //    }

        //}
    }
}
