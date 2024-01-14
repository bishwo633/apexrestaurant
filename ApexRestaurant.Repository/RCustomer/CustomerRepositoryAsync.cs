using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository.RCustomer;

public class CustomerRepositoryAsync : GenericRepositoryAsync<Customer>, ICustomerRepositoryAsync
{
    public CustomerRepositoryAsync(RestaurantContext dbContext)
    {
        DbContext = dbContext;
    }
}