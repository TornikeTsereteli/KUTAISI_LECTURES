using Lecture_9_EFCore.Context;
using Lecture_9_EFCore.Entities;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        AppDbContext dbContext = new AppDbContext();
        
        // var employess = dbContext.Employees.Where(x=>x.Salary > 50000).ToList();

        
        dbContext.Employees.Add(new Employee { FirstName = "John", LastName = "Doe", Salary = 60000 });
        dbContext.SaveChanges();
        
        
        var employess = dbContext.Employees.ToList();

        foreach (var employee in employess)
        {
            Console.WriteLine(employee.FirstName);
        }
    }
}