using RepositoryPatternEx.Models;
using RepositoryPatternEx.Repositories.Classes;
using RepositoryPatternEx.Repositories.Interfaces;

namespace RepositoryPatternEx.Bootstrapper
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Customer>, Repository<Customer>>();
            services.AddScoped<IRepository<Product>, Repository<Product>>();
            services.AddScoped<IRepository<Order>, Repository<Order>>();
            return services;
        }
    }
}
