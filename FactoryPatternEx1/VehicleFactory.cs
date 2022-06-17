using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx1
{
    internal class VehicleFactory
    {
       
        public static IVehicle GetVehicle(string numberOfTires)
        {
            switch (numberOfTires)
            {
                case "2":
                    return new Motorcycle();
                case "4":
                    return new Car();
                case "18":
                    return new SemiTruck();
                default:
                    return new Default();
            }
        }
    }
}
