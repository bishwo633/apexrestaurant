using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ApexRestaurant.Repository.RCustomer;
using ApexRestaurant.Repository;

public static class RepositoryModule
{
    public static void Register(IServiceCollection services, string connection,
    string migrationsAssembly)
    {
        services.AddDbContext<RestaurantContext>(options =>
            options.UseSqlite(connection, builder =>
                builder.MigrationsAssembly(migrationsAssembly)));

        // dependency injection
        services.AddTransient<ICustomerRepository, CustomerRepository>();
        services.AddTransient<ICustomerRepositoryAsync, CustomerRepositoryAsync>();
    }
}