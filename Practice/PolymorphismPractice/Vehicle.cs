using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismPractice
{
    abstract class Vehicle
    {
        public int Year { get; set; }
        public string Color { get; set; }

        public Vehicle(int year)
        {
            Year = year;
        }

        public abstract void ShowInfo();
    }
}
