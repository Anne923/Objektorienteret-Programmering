using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyrelyde_Interface
{
    public class Cat : IFeedable, IMakeSound
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public void Feed()
        {
            Console.WriteLine("Cat is nibbling on tuna.");
        }
    }
}
