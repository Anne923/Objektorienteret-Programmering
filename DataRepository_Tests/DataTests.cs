using DataRepository_Dependency;
using Moq;

namespace DataRepository_Tests
{
    public class DataTests
    {
        [Fact]
        public void AddAndListProducts_ShouldCallRepositoryMethods()
        {
            // Arrange
            var mockRepo = new Mock<IProductRepository>();
            mockRepo.Setup(r => r.GetAllProducts()).Returns(new List<string> { "MockProdukt" });

            var productService = new ProductService(mockRepo.Object);

            // Act
            productService.AddAndListProducts("TestProdukt");

            // Assert
            mockRepo.Verify(r => r.AddProduct("TestProdukt"), Times.Once);
            mockRepo.Verify(r => r.GetAllProducts(), Times.Once);
        }
    }
}
