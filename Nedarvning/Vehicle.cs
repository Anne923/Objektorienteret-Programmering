using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Nedarvning
{
    internal abstract class Vehicle
    {
        public string Brand { get; set; }
        public int MaxSpeed { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine($"The vehicle is moving");
        }
    }
}
