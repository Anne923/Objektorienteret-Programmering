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

            // Call the methods to actually do something!
            DocumentProcessor.PrintAllDocuments(printableDocs);
            DocumentProcessor.SaveAllDocuments(saveableDocs, "C:/Documents/");
        }
    }
}
