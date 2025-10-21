using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppAssignments.modules
{
    internal class Truck : Vehicle
    {
        public Truck(string make, string model, int year, double loadCapacity) : base(make, model, year)
        {
            this.loadCapacity = loadCapacity;
        }
        public double loadCapacity { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Vehicle Type: Truck");
            Console.WriteLine($"Make: {make}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Load Capacity: {loadCapacity} tons");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }
    }

}
