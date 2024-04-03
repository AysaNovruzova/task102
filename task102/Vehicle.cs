using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task102
{
    internal class Vehicle
    {
        public string Color { get; set; }
        public int Year { get; }
        public Vehicle(int year)
        {
            Year = year;
        }
        public abstract void ShowInfo();
    }
}
