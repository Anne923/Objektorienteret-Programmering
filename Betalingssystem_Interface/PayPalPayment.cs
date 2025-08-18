using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betalingssystem_Interface
{
    public class PayPalPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount} kr");
        }
    }
}
