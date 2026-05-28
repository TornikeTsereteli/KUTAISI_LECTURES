namespace Lecture11_EFCORE_Migrations.Entities;

public class Enrollment
{
    public int StudentId { get; private set; }
    public Student Student { get; private set; }
    
    public  int CourseId { get; private set; }
    public Course Course { get; private set; }
    
    public decimal Grade { get; private set; }
    public DateTime EnrollmentDate { get; private set; }

    public Enrollment(int studentId, int courseId)
    {
        StudentId = studentId;
        CourseId = courseId;
        EnrollmentDate = DateTime.Now;
        Grade = 0;
    }
    
}