using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx1
{
    internal class Default : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("I don't know a vehicle with that number of wheels.");
        }
    }
}
