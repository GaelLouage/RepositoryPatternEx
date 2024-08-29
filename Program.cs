using RepositoryPatternEx.Bootstrapper;
using RepositoryPatternEx.Data;
using RepositoryPatternEx.Models;
using RepositoryPatternEx.Repositories.Classes;
using RepositoryPatternEx.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddServices();
var app = builder.Build();

app.MapGet("/", (IRepository<Customer> customerRepo) =>
{
	try
	{
		var updateJohn = customerRepo.GetSingleDataByCustomRule(x => x.Name
									 .Equals("John Doe"),
									 CustomerData.Customers);
		updateJohn.Products.Add(new Product()
		{
			Id = Guid.NewGuid(),
            Name = "AlienWare",
            Category = "Electronics",
			Description = "Desktop",
        });
		customerRepo.Update(updateJohn, CustomerData.Customers, x => x.Name.Equals("John Doe"));
        return Results.Ok(updateJohn);
	}
	catch (Exception ex)
	{
		return Results.BadRequest(ex.Message);
	}
});

app.Run();
