using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Nedarvning
{
    internal abstract class Animal
    {
        public string Name { get; set; }

        public abstract void MakeSound();

        public void Feed()
        {
            Console.WriteLine("Feeding the animal.");
        }
    }
}
