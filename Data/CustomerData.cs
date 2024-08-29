using RepositoryPatternEx.Models;

namespace RepositoryPatternEx.Data
{
    public static class CustomerData
    {
        public static List<Customer> Customers = new List<Customer>
        {
            new Customer
            {
                Id = Guid.NewGuid(),
                Name = "John Doe",
                Orders = new List<Order> { OrdersData.Orders[0] },
                Products = { ProductData.Products[0], ProductData.Products[1] }
            },
            new Customer
            {
                Id = Guid.NewGuid(),
                Name = "Jane Smith",
                Orders = new List<Order> { OrdersData.Orders[1] },
                Products = { ProductData.Products[2] }
            }
        };

    }
}
