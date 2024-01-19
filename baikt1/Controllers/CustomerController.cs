using baikt1.Models;
using Microsoft.AspNetCore.Mvc;

namespace baikt1.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            List<Customer> customers = CustomerService.GetAllCustomers();
            return View(customers);
        }

        
    }

}
