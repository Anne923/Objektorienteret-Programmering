using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetalingsGetaway_Dependency
{
    public class StripePaymentProcessor : IPaymentProcessor
    {
        public void Process(decimal amount)
        {
             Console.WriteLine($"Stripe processed payment of {amount:C}");
        }
    }
}
