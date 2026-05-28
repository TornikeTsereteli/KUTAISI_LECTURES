using Lecture10.Context;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        AppDbContext appDbContext = new AppDbContext();
        appDbContext.Database.EnsureCreated();


        var students = appDbContext.Students.ToList();

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("___________________________________________");

        foreach (var employee in appDbContext.Employees.ToList())
        {
            Console.WriteLine(employee);
        }

        Console.WriteLine("___________________________________________");

        foreach (var product in appDbContext.Products.ToList())
        {
            Console.WriteLine(product);
        }


        var itDepartmentEmployees = appDbContext
            .Employees
            .Where(x => x.Department == "IT")
            .ToList();


        Console.WriteLine("___________________________________________");

        foreach (var employee in itDepartmentEmployees)
        {
            Console.WriteLine(employee);
        }


        var maximalGpa = appDbContext.Students.Max(x => x.Gpa);
        Console.WriteLine(maximalGpa);


        var cityToCount = appDbContext.Students
            .GroupBy(x => x.City)
            .Select(x => new
        {
            City = x.Key,
            NumberOfStudents = x.Count()
        }).ToList();

        foreach (var city in cityToCount)
        {
            Console.WriteLine(city.City);
            Console.WriteLine(city.NumberOfStudents);
        }


        var studentGrades = 
            appDbContext
            .Students
            .Include(x => x.Grades).ToList();

        foreach (var studentGrade in studentGrades)
        {
            if (studentGrade.Grades.Count > 0)
            {
                Console.WriteLine($"{studentGrade.FullName} {studentGrade.Grades.Average(x => x.Point)}");
            }
        }


    }
}