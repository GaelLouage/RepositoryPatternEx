using RepositoryPatternEx.Models;

namespace RepositoryPatternEx.Data
{
    public static class OrdersData
    {
        public static List<Order> Orders = new List<Order>
        {
            new Order { Id = Guid.NewGuid(), Name = "Order 1", Description = "First order description", Category = "Electronics" },
            new Order { Id = Guid.NewGuid(), Name = "Order 2", Description = "Second order description", Category = "Furniture" }
        };
    }
}
