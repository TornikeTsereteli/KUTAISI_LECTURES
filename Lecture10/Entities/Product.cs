namespace Lecture10.Entities;

public class Product
{
    public int Id{get;set;}
    public string? ProductName { get; set; }
    public string? Category { get; set; }
    public decimal? Price { get; set; }
    public int? Stock { get; set; }
    public string? Brand { get; set; }
    public decimal? Rating { get; set; }

    public override string ToString()
    {
        return $"{ProductName} {Category} {Price} {Stock} {Brand} {Rating}";
    }
}