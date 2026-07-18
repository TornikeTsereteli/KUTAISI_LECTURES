namespace Exerciece_EFCORE.Entities;

public class Customer
{
    public int Id { get; private set; }
    public string PersonalNumber { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    
    public ICollection<Loan> Loans { get; private set; }


    private Customer(string personalNumber, string firstName, string lastName)
    {
        PersonalNumber = personalNumber;
        FirstName = firstName;
        LastName = lastName;
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }
    
    public static Customer Create(string personalNumber, string firstName, string lastName)
    {
        return new Customer(personalNumber, firstName, lastName);
    }
}