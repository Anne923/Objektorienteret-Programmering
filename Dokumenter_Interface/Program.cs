namespace Dokumenter_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var printableDocs = new List<IPrintable>
            {
            new Invoice(),
            new Report(),
            new Letter()
            };

            var saveableDocs = new List<ISaveable>
            {
            new Invoice(),
            new Report()
            };

            
            DocumentProcessor.PrintAllDocuments(printableDocs);
            DocumentProcessor.SaveAllDocuments(saveableDocs, "C:/Documents/");
        }
    }
}
