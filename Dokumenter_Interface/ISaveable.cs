using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dokumenter_Interface
{
    public interface ISaveable
    {
        void Save(string filePath);
    }
}
