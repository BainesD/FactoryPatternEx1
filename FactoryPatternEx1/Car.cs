using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx1
{
    internal class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building a new Car!");
        }

    }
}
