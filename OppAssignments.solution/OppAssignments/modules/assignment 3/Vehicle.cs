using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppAssignments.modules
{
    public class Vehicle
    {
        public Vehicle (string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }
        public string make { get; set;  }
        public string model { get; set; }
        public int year { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Make: {make}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Year: {year}");
        }

    }
}
