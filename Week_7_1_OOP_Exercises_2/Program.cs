using Week_7_1_OOP_Exercises_2.Inheritance;
using Week_7_1_OOP_Exercises_2.Task1;

public class Program
{
    public static void Main(string[] args)
    {
        // Example: readings {36.8, 37.1, 38.0} in C -> average 37.3, CountAbove(37.0) = 2,
        // HasFeverReadings() = true.

        double[] readings = [36.8, 37.1, 38.0];
        
        ThermometerLog log = new ThermometerLog("panama", readings, 'C');
        Console.WriteLine($"Average temperature: {log.GetAverage()}");
        Console.WriteLine($"Has fever: {log.HasFever()}");
        
        
        
        // Create a myCar object
        Car myCar = new Car();

        // Call the honk() method (From the Vehicle class) on the myCar object
        myCar.honk();
        

        // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
        Console.WriteLine(myCar.brand + " " + myCar.modelName);

        B b = new B(123,123,123);
        b.GetSomething();

        Employee e1 = new Employee("0100501041","gela"); // 1000
        Employee e2 = new Manager("60001152313","nika"); // 2500
        Employee e3 = new Director("60001152313","gia"); // 6000 

        e2.GetSalary();
        
        List<Employee> employees = [e1, e2, e3];
        int sum = 0;
        foreach (Employee employee in employees)
        {
            sum += employee.GetSalary();
        }

        Console.WriteLine(sum);
        


    }
    
    
    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {                    
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }

   
   
}