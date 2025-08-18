using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyrelyde_Interface
{
    public class Cow : IMakeSound
    {
        public void MakeSound()
        {
            Console.WriteLine("Moo");
        }
    }
}
