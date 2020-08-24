using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Client
    {
        public static void Execute()
        {
            VehicleBuilder builder1 = new VehicleBuilder();
            builder1
            .SetSeats(2)
            .SetDoors(2)
            .SetEnginePower(25)
            .SetWheels(4);

            ManufacturingInfoBuilder builder2 = new ManufacturingInfoBuilder(builder1.Buiild());
            builder2
            .SetManufacturer("Altkom")
            .SetDateTime(DateTime.Now);

            var builder = new VehicleBuilderFacade();
            builder
                .Components
            .SetSeats(2)
            .SetDoors(2)
            .SetEnginePower(25)
            .SetWheels(4)
                .Manufacturing
            .SetManufacturer("Altkom")
            .SetDateTime(DateTime.Now);

            var vehicle = builder2.Buiild();

            Console.WriteLine(vehicle);
        }
    }
}
