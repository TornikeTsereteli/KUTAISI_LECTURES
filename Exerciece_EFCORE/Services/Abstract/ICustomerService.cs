using Exerciece_EFCORE.Entities;

namespace Exerciece_EFCORE.Services.Abstract;

public interface ICustomerService
{
    void CreateCustomer(string firstName, string lastName, string personalNumber);
    List<Customer> GetAll();
}