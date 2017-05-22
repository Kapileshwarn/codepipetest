using System.Collections.Generic;
using NUnit.Framework;
using Rhino.Mocks;
using WroxPizza.Core.Data.Repositories;
using WroxPizza.Core.Model;
using WroxPizza.Core.Web.Controllers;
using WroxPizza.Core.Web.ViewModels;

namespace WroxPizza.Tests.Unit.Web.Controllers
{
    [TestFixture]
    public class ProductsMenuControllerTests
    {
        List<Product> products;
        [SetUp]
        public void Setup()
        {
            products = new List<Product>
                           {
                               new Product
                                   {
                                       ID = 1,
                                       Name = "Classic Cheese",
                                       Description = "Classic Cheese",
                                       BasePrice = 8.00
                                   },
                           };
        }

        [Test]
        public void Index_Returns_All_Products_In_Database()
        {
            IProductRepository repository = MockRepository.GenerateStub<IProductRepository>();
            repository.Stub(r => r.GetAll()).Return(products);

            ProductsMenuController controller = new ProductsMenuController(repository);
            ProductsMenuModel model = controller.Index().GetModel<ProductsMenuModel>();

            Assert.AreEqual(1, model.Products.Count);
        }
    }
}
