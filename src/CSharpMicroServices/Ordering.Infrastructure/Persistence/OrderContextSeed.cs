using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Ordering.Domain.Entities;

namespace Ordering.Infrastructure.Persistence;

public class OrderContextSeed
{
    public static async Task SeedAsync(OrderContext orderContext, ILogger<OrderContextSeed> logger)
    {
        if (!orderContext.Orders.Any())
        {
            orderContext.Orders.AddRange(GetPreconfiguredOrders());
            await orderContext.SaveChangesAsync();
            logger.LogInformation("Seed database associated with context {DbContextName}", typeof(OrderContext).Name);
        }
    }

    public static IEnumerable<Order> GetPreconfiguredOrders()
    {
        return new List<Order>
        {
            new Order()
            {
                UserName = "Notch", FirstName = "Amir", LastName = "Ibragimov", EmailAddress = "ibragimov-amir@list.ru",
                AddressLine = "Quarabaev", Country = "Tajikistan", TotalPrice = 500, CVV = "002", State = "Dushanbe", ZipCode = "000723",
                CardName = "AMIR IBRAGIMOV", CardNumber = "5454 0000 2892 0782", Expiration = "15.02.2027", LastModifiedBy = "AMIR"
            }
        };
    }
}