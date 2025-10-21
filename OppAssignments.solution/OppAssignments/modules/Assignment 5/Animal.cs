using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppAssignments.modules.Assignment_5
{
    public abstract class Animal
    {
        public Animal(string name)
        {
            this.name = name;
        }

        public string name { get; set; }

        public abstract void MakeSound();

        public void DisplayInfo()
        {
            Console.Write($"{name} says: ");
        }
    }
}
