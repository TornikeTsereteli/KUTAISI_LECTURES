namespace Lecture11_EFCORE_Migrations.Entities;

public class Student
{
    public int Id { get; private set; }
    public string FullName { get; private set; }
    
    public DateTime BirthDate { get; private set; }
    
    public ICollection<Enrollment> Enrollments { get; private set; } =  new List<Enrollment>();


    private Student(string fullName, DateTime birthDate)
    {
        FullName = fullName;
        BirthDate = birthDate;
    }

    public static Student Create(string fullName, DateTime birthDate)
    {
        return new Student(fullName, birthDate);
    }
}