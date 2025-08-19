namespace DataRepository_Dependency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductRepository repo1 = new InMemoryProductRepository();
            IProductRepository repo2 = new SqlProductRepository();

            var service1 = new ProductService(repo1);
            var service2 = new ProductService(repo2);

            Console.WriteLine("=== InMemory Test ===");
            service1.AddAndListProducts("Kaffe");

            Console.WriteLine("\n=== SQL Test ===");
            service2.AddAndListProducts("Te");
        }
    }
}
