using System;

namespace FactoryPatternEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires does the vehicle have?");
            string userTires = Console.ReadLine();

            IVehicle vehicle =  VehicleFactory.GetVehicle(userTires);
            vehicle.Drive();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
