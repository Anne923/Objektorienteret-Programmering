using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Betalingssystem_Nedarvning
{
    internal class PayPalPayment : Payment
    {
        public string Email { get; set; }

        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing PayPal payment of {Amount} {Currency} from account {Email}");
        }
    }
}
