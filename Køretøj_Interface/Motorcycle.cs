using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køretøj_Interface
{
    public class Motorcycle : Vehicle, IDriveable
    {
        public Motorcycle(string brand) : base(brand) { }

        public void Start()
        {
            Console.WriteLine($"{Brand} motorcycle started.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} motorcycle stopped.");
        }
    }
}
