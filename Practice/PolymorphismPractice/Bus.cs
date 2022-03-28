using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismPractice
{
    internal class Bus : Vehicle
    {
        public int PassengerCount { get; set; }

        public Bus(int passengerCount, int year) : base(year)
        {
            PassengerCount = passengerCount;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"PassengerCount: {PassengerCount} - Year: {Year}");
        }
    }
}
