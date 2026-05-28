using Lecture11_EFCORE_Migrations.Enums;

namespace Lecture11_EFCORE_Migrations.Entities;

public class Teacher
{
    public int Id { get; private set; }
    public string FullName { get; private set; }
    public Departament Departament { get; private set; }
    
    public ICollection<Course> Courses { get; private set; } = new  List<Course>();
    
    private  Teacher(string fullName, Departament departament)
    {
        FullName = fullName;
        Departament = departament;
    }

    public static Teacher Create(string fullName,Departament departament)
    {
        return new Teacher(fullName, departament);
    }
    
}