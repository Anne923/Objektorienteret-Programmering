using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betalingssystem_Nedarvning
{
    internal abstract class Payment
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public virtual void ProcessPayment()
        {
            Console.WriteLine("Processing generic payment");
        }
    }
}
