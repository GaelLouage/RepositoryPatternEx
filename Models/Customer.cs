namespace RepositoryPatternEx.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set;} = new List<Order>();
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
