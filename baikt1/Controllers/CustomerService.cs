using baikt1.Models;

namespace baikt1.Controllers
{
    public static class CustomerService
    {
        private static List<Customer> customers = new List<Customer>
    {
        new Customer { Id = 1, Name = "Khách hàng 1" },
        new Customer { Id = 2, Name = "Khách hàng 2" },
        // Thêm dữ liệu khác
    };

        public static List<Customer> GetAllCustomers()
        {
            return customers;
        }

       
    }
}
