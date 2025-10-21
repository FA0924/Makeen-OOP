using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppAssignments.modules.Assignment_5
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            DisplayInfo();
            Console.WriteLine("Meow!");
        }
    }
}
