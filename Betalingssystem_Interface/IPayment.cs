using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betalingssystem_Interface
{
    public interface IPayment
    {
        void ProcessPayment(decimal amount);


    }
}
