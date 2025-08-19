using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository_Dependency
{
    public class SqlProductRepository : IProductRepository
    {
        public List<string> GetAllProducts()
        {
            Console.WriteLine("[SQL] Henter produkter fra databasen...");
            return new List<string> { "Produkt A", "Produkt B" };
        }

        public void AddProduct(string name)
        {
            Console.WriteLine($"[SQL] Tilføjer produkt '{name}' til databasen...");
        }
    }
}
