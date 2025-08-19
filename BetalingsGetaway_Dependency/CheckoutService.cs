using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetalingsGetaway_Dependency
{
    public class CheckoutService
    {
        private readonly IPaymentProcessor _paymentProcessor;
        public CheckoutService(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void Checkout(decimal amount)
        {
            _paymentProcessor.Process(amount);
        }
    }
}
