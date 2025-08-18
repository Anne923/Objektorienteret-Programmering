using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dokumenter_Interface
{
    public static class DocumentProcessor
    {
        public static void PrintAllDocuments(List<IPrintable> documents)
        {
            foreach (var doc in documents)
            {
                doc.Print();
                Console.WriteLine();
            }
        }

        public static void SaveAllDocuments(List<ISaveable> documents, string path)
        {
            foreach (var doc in documents)
            {
                doc.Save(path);
            }
        }
    }
}
