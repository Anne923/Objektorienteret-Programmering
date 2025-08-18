using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betalingssystem_Nedarvning
{
    internal class CreditCardPayment : Payment
    {
        public string CardNumber { get; set; }

        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing credit card payment of {Amount} {Currency} using card {CardNumber}");
        }
    }
}
