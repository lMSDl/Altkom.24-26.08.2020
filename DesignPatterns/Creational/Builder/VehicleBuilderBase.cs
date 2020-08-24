using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public abstract class VehicleBuilderBase
    {
        protected Vehicle Vehicle { get; }

        protected VehicleBuilderBase(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }

        protected VehicleBuilderBase()
        {
            Vehicle = new Vehicle();
        }

        public Vehicle Buiild()
        {
            return Vehicle;
        }

    }
}
