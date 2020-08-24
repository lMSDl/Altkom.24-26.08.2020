using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class ManufacturingInfoBuilder : VehicleBuilderFacade
    {
        public ManufacturingInfoBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public ManufacturingInfoBuilder SetManufacturer(string manufacturer)
        {
            Vehicle.Manufacturer = manufacturer;
            return this;
        }

        public ManufacturingInfoBuilder SetDateTime(DateTime dateTime)
        {
            Vehicle.DateTime = dateTime;
            return this;
        }
    }
}
