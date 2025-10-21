using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppAssignments.modules
{
    internal class Car : Vehicle
    {
        public Car(string make, string model, int year, int doorsnumber) : base (make, model, year)
        {
        this.doorsnumber = doorsnumber;
        }
        public int doorsnumber { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Vehicle Type: Car");
            Console.WriteLine($"Make: {make}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Number of Doors: {doorsnumber}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }
    }
}
