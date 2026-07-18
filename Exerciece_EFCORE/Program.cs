using Exerciece_EFCORE.Context;
using Exerciece_EFCORE.Services;
using Exerciece_EFCORE.Services.Abstract;

public class Program
{
    public static void Main(string[] args)
    {
        var appDbContext = new AppDbContext();
        
        ICustomerService customerService = new CustomerService(appDbContext);
        
        customerService.CreateCustomer("John", "Doe", "01000000001");

        customerService.GetAll()
            .ForEach(c => Console.WriteLine(c.FirstName));
        
        
    }
}

