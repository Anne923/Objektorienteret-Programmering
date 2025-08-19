using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetalingsGetaway_Dependency
{
    public interface IPaymentProcessor
    {
        void Process(decimal amount);
    }
}
