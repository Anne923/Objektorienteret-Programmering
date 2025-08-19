using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository_Dependency
{
    public class InMemoryProductRepository : IProductRepository
    {
        private readonly List<string> _products = new();

        public List<string> GetAllProducts() => new List<string>(_products);

        public void AddProduct(string name)
        {
            _products.Add(name);
        }
    }
}
