using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetalingsGetaway_Dependency
{
    public class FakePaymentProcessor : IPaymentProcessor
    {
        public void Process(decimal amount)
        {
            Console.WriteLine($"[Fake] Pretending to process {amount:C}");
        }
    }
}
