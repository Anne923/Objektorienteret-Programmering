using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dokumenter_Interface
{
    public class Invoice : IPrintable, ISaveable
    {
        public void Print()
        {
            Console.WriteLine("Invoice:\nAmount Due: 1.200 kr\nDue Date: 01-09-2025");
        }

        public void Save(string path)
        {
            Console.WriteLine($"Invoice saved to {path}");
        }
    }
}
