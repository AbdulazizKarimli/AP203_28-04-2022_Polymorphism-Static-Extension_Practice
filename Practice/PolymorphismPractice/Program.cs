using System;

namespace PolymorphismPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("bmw", "m5", 2020);
            Bus bus = new Bus(15, 1999);

            Vehicle[] vehicles = {car, bus};

            foreach (var vehicle in vehicles)
            {
                vehicle.ShowInfo();
            }
        }
    }
}
