using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyrelyde_Interface
{
    public class Dog : IFeedable, IMakeSound
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof");
        }

        public void Feed()
        {
            Console.WriteLine("Dog is eating kibble.");
        }
    }
}
