using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository_Dependency
{
    public interface IProductRepository
    {
        List<string> GetAllProducts();
        void AddProduct(string product);
    }
}
