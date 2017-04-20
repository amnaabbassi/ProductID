using ProductID.DAL;
using ProductID.Service;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProductID.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _ProductService;

        public ProductController(IProductRepository ProductService)
        {
            _ProductService = ProductService;
        }
        // GET: Product
        public ActionResult Index()
        {
            List<Product> product = _ProductService.GetAll();
            return View(product);
        }
    }
}
