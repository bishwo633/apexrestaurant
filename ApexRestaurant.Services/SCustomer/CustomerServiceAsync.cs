using System.Security.Cryptography.X509Certificates;
using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RCustomer;
using ApexRestaurant.Repository.RSupplier;
// using ApexRestaurant.Repository.aws;

namespace ApexRestaurant.Services.SCustomer;
public class CustomerServiceAsync : GenericServiceAsync<Customer>, ICustomerServiceAsync
{
    public CustomerServiceAsync(ICustomerRepositoryAsync CustomerRepositoryAsync) : base(CustomerRepositoryAsync)
    {

    }
}