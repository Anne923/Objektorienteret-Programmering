using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Nedarvning
{
    internal class Lion : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} roars.");
        }
    }
}
