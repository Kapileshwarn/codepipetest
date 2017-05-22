using System.Collections.Generic;
using System.Web.Mvc;
using WroxPizza.Core.Data.Repositories;
using WroxPizza.Core.Model;
using WroxPizza.Core.Web.ViewModels;

namespace WroxPizza.Core.Web.Controllers
{
    public class ProductsMenuController : Controller
    {
        private readonly IProductRepository Repository;

        public ProductsMenuController(IProductRepository repository)
        {
            Repository = repository;
        }
        public ActionResult Index()
        {
            ProductsMenuModel model = new ProductsMenuModel();
            List<Product> products = Repository.GetAll();
            model.Products = products;

            return View(model);
        }
    }
}
