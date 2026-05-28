namespace Lecture10.Entities;

public class Student
{
    public int Id { get; set; }
    public string? FullName { get; set; }
    public int? Age { get; set; }
    public string? City { get; set; }
    public string? Major { get; set; }
    public decimal? Gpa { get; set; }
    public int EnrollmentYear { get; set; }
    
    public List<Grade> Grades { get; set; }

    public override string ToString()
    {
        return $"{FullName}, {Age}, {City}, {Major}, {Gpa}";
    }
}