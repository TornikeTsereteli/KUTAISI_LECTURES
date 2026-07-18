namespace Exerciece_EFCORE.Entities;

public class Payment
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public int LoanId { get; set; }
}