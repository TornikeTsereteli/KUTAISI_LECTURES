using Exerciece_EFCORE.Context;
using Exerciece_EFCORE.Entities;
using Exerciece_EFCORE.Services.Abstract;

namespace Exerciece_EFCORE.Services;

public class CustomerService : ICustomerService
{
    private readonly AppDbContext _appDbContext;

    public CustomerService(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public void CreateCustomer(string firstName, string lastName, string personalNumber)
    {
        var customer = Customer.Create(personalNumber, firstName, lastName);
        _appDbContext.Customers.Add(customer);
        _appDbContext.SaveChanges();
    }

    public List<Customer> GetAll()
    {
        return  _appDbContext.Customers.ToList();
    }
}