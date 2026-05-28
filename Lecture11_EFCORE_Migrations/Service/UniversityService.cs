using Lecture11_EFCORE_Migrations.Context;
using Lecture11_EFCORE_Migrations.Entities;
using Lecture11_EFCORE_Migrations.Enums;

namespace Lecture11_EFCORE_Migrations.Service;

public class UniversityService
{
    private AppDbContext _context;

    public UniversityService(AppDbContext context)
    {
        _context = context;
    }


    public void AddStudent(string fullName, DateTime birthDate)
    {
        var student = Student.Create(fullName, birthDate);
        _context.Students.Add(student);
        _context.SaveChanges();
    }


    public void AddTeacher(string fullName, Departament departament)
    {
        var teacher = Teacher.Create(fullName, departament);
        _context.Teachers.Add(teacher);
        _context.SaveChanges();
    }


    public void AddCourse(string name, int credits, Teacher teacher)
    {
        var course = Course.Create(name, credits);
        course.SetTeacher(teacher);
        _context.Courses.Add(course);
        _context.SaveChanges();
    }

    public void EnrollCourse(int studentId, int courseId)
    {
        var enrollment = new Enrollment(studentId, courseId);
        _context.Enrollments.Add(enrollment);
        _context.SaveChanges();
    }
        
}