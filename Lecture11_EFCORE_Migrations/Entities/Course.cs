namespace Lecture11_EFCORE_Migrations.Entities;

public class Course
{
    public int Id{ get; private set; }
    public string Name{ get; private set; }
    public int Credits{ get; private set; }
    
    
    public int TeacherId { get; private set; }
    public Teacher Teacher { get; private set; }
    
    public ICollection<Enrollment> Enrollments { get; private set; } = new List<Enrollment>();

    private Course(string name, int credits)
    {
        this.Name = name;
        this.Credits = credits;
    }

    public static Course Create(string name, int credits)
    {
        return new Course(name, credits);
    }


    public Course SetTeacher(Teacher teacher)
    {
        this.Teacher = teacher;
        return this;
    }

    public Course AddEnrollment(Enrollment enrollment)
    {
        Enrollments.Add(enrollment);
        return this;
    }
    
}