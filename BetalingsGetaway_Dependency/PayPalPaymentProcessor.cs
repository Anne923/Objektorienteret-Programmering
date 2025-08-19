using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetalingsGetaway_Dependency
{
    public class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void Process(decimal amount)
        {
            Console.WriteLine($"PayPal processed payment of {amount:C}");
        }
    }
}
