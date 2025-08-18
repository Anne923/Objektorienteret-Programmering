using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køretøj_Interface
{
    public class Car : Vehicle, IDriveable
    {
        public Car(string brand) : base(brand) { }
        
        public void Start()
        {
            Console.WriteLine($"{Brand} car started.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} car stopped.");
        }
    }
}
