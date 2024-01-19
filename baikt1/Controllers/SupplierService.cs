using baikt1.Models;

namespace baikt1.Controllers
{
    public static class SupplierService
    {
        private static List<Supplier> suppliers = new List<Supplier>
    {
        new Supplier { Id = 1, Name = "Nhà cung cấp 1" },
        new Supplier { Id = 2, Name = "Nhà cung cấp 2" },
        // Thêm dữ liệu khác
    };

        public static List<Supplier> GetAllSuppliers()
        {
            return suppliers;
        }


    }
}
