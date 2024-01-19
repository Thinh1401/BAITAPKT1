using baikt1.Models;
using Microsoft.AspNetCore.Mvc;

namespace baikt1.Controllers
{
    public class SupplierController : Controller
    {
        public ActionResult Index()
        {
            List<Supplier> suppliers = SupplierService.GetAllSuppliers();
            return View(suppliers);
        }

       
    }
}
