using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dokumenter_Interface
{
    public class Report : IPrintable, ISaveable
    {
        public void Print()
        {
            Console.WriteLine("Report:\nQ2 Sales increased by 15%");
        }

        public void Save(string path)
        {
            Console.WriteLine($"Report saved to {path}");
        }
    }
}
