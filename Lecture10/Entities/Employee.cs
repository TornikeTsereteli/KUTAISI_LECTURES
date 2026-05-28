namespace Lecture10.Entities;

public class Employee
{
    public int Id { get; set; }
    public string? FullName { get; set; }
    public string? Department { get; set; }
    public string? Position { get; set; }
    public decimal? Salary { get; set; }
    public string? City { get; set; }
    public int? YearsExperience { get; set; }

    public override string ToString()
    {
        return $"{FullName} {Department} {Position} {Salary} {City} {YearsExperience}";
    }
}