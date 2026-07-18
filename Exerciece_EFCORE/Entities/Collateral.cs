namespace Exerciece_EFCORE.Entities;

public class Collateral
{
    public int Id { get; private set; }
    public string Description { get; private set; }
    public decimal Value { get; private set; }
    public int LoanId { get; private set; }
}