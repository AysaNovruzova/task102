using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task102
{
    internal class Bus: Vehicle
    {
        private int passengerCount;
        public int PassengerCount
        {
            get { return passengerCount; }
            set { passengerCount = value; }
        }

        public Bus(int passengerCount, int year) : base(year)
        {
            PassengerCount = passengerCount;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Bus: Passenger Count: {PassengerCount}, Year: {Year}, Color: {Color}");
        }
    }
}
