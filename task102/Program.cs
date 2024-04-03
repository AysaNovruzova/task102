
namespace task102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[]
        {
            new Car("Toyota", "Camry", 180, 2019) { Color = "Red" },
            new Bus(30, 2020) { Color = "Blue" }
        }
            foreach (var vehicle in vehicles)
            {
                vehicle.ShowInfo();
            }
        }
    }
}
