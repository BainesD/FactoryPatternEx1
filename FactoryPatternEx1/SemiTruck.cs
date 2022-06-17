using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx1
{
    internal class SemiTruck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building a new Semi-Truck");
        }
    }
}
