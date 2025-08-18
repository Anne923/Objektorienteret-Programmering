using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dokumenter_Interface
{
    public class Letter : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Letter:\nDear Anne,\nThank you for your inquiry...");
        }
    }
}
