using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Nedarvning
{
    internal class Elephant : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} trumpets.");
        }
    }
}
