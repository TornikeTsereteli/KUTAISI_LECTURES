namespace Exerciece_EFCORE.Entities;

public class Loan
{
    public int Id { get; private set; }
    public decimal Amount { get; private set; }
    public decimal InterestRate { get; private set; }

    public DateTime StartDate { get; private set; }
    public int CountOfMonths { get; private set; }
    
    public int CustomerId { get; private set; }
    public Customer Customer { get; private set; }
    
    public int ProductId { get; private set; }
    public Product Product { get; private set; }

    public ICollection<Payment> Payments { get; private set; } = [];
    public ICollection<Collateral> Collaterals { get; private set; } = [];
    
    public DateTime CreateAt { get; private set; }
    public DateTime? UpdateAt { get; private set; }
}