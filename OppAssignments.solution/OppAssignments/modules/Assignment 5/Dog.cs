using OppAssignments.modules.Assignment_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppAssignments.modules.Assignment_6
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            DisplayInfo();
            Console.WriteLine("Woof!");
        }
    }
}