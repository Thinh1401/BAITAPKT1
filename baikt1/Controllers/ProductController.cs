using baikt1.Models;
using Microsoft.AspNetCore.Mvc;

namespace baikt1.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = ProductService.GetAllProducts();
            return View(products);
        }

        
    }
}