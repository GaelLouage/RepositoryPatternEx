using RepositoryPatternEx.Models;

namespace RepositoryPatternEx.Data
{
    public static class ProductData
    {
        public static List<Product> Products = new List<Product>
        {
            new Product { Id = Guid.NewGuid(), Name = "Laptop", Description = "High performance laptop", Category = "Electronics" },
            new Product { Id = Guid.NewGuid(), Name = "Phone", Description = "Latest smartphone", Category = "Electronics" },
            new Product { Id = Guid.NewGuid(), Name = "Desk Chair", Description = "Ergonomic desk chair", Category = "Furniture" }
        };
    }
}
