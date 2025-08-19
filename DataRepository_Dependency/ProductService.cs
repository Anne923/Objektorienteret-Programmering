using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository_Dependency
{
    public class ProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public void AddAndListProducts(string newProduct)
        {
            _repository.AddProduct(newProduct);
            var products = _repository.GetAllProducts();

            Console.WriteLine("Produkter:");
            foreach (var product in products)
            {
                Console.WriteLine($"- {product}");
            }
        }
    }
}
