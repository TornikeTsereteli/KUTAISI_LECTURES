using Lecture11_EFCORE_Migrations.Context;
using Lecture11_EFCORE_Migrations.Entities;
using Lecture11_EFCORE_Migrations.Enums;
using Lecture11_EFCORE_Migrations.Service;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main()
    {
        var dbContext = new AppDbContext();

        var universityService = new UniversityService(dbContext);

        // universityService.AddStudent("gela",new DateTime(2003,02,02));
        // universityService.AddStudent("nino",new DateTime(2003,01,09));
        // universityService.AddStudent("luka",new DateTime(2003,12,02));
        // universityService.AddStudent("wero",new DateTime(2003,02,12));
        //
        //
        // universityService.AddTeacher("wero", Departament.Computer_Science);
        // universityService.AddTeacher("luksona",Departament.Mathematics);

        // var teacher = dbContext.Teachers.FirstOrDefault(x => x.Id == 1);
        //
        // ArgumentNullException.ThrowIfNull(teacher);
        //
        // universityService.AddCourse("FOP", 6, teacher);
        //
        //
        
        
        // var student = dbContext.Students.First();
        // var course = dbContext.Courses.First();
        //
        // universityService.EnrollCourse(student.Id, course.Id);
        //


        var students = dbContext.Students
            .Where(x => x.Id == 1)
            .Include(x => x.Enrollments)
            .ThenInclude(x => x.Course)
            .ToList();

        var student = students.First();
        
        foreach (var enrollment in student.Enrollments)
        {
            Console.WriteLine($"{student.FullName} {enrollment.Course.Name}");
            // Console.WriteLine(enrollment.Course.Name);
        }


    }
}