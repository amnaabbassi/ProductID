using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductID.Controllers;

using ProductID.Service;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Entities;

namespace UnitTestProduct
{
    [TestClass]
    public class ProductControllerTest
    {
    
        [TestMethod]
        public void TestIndex()
        {
            var productList = new List<Product>
        {
            new Product {Id= 0 ,Price = 1, Name = "P1"},
            new Product {Id = 1,Price = 2, Name = "P2"},
            new Product {Id = 3,Price = 3, Name = "P3"},
            new Product {Id = 4 ,Price = 4, Name = "P4"},
            new Product {Id = 5,Price = 5, Name = "P5"}
        };
            var fakeProductRepository = new Mock<IProductRepository>();
            fakeProductRepository.Setup(f => f.GetAll()).Returns(productList.ToList());

            //Arrange
            var controller = new ProductController(fakeProductRepository.Object);

            //Act
            ViewResult result = controller.Index() as ViewResult;
            List<Product> product = result.Model as List<Product>;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, product.FirstOrDefault().Price);
        }
    }
}
