using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task102
{
    internal class Car
    {
        public string Brand { get; }
        public string Model { get; }
        private int maxSpeed;
        public int MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
        }
        public Car(string brand, string model, int maxSpeed, int year) : base(year)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Car: {Brand} {Model}, Year: {Year}, Color: {Color}, Max Speed: {MaxSpeed} km/h");
        }
    }
}
