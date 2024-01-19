using baikt1.Models;

namespace baikt1.Controllers
{
    public static class ProductService
    {
        private static List<Product> products = new List<Product>
    {
        new Product { Id = 1, Name = "Sản phẩm 1" },
        new Product { Id = 2, Name = "Sản phẩm 2" },
        // Thêm dữ liệu khác
    };

        public static List<Product> GetAllProducts()
        {
            return products;
        }

        // Thêm các phương thức khác liên quan đến quản lý sản phẩm
    }
}
