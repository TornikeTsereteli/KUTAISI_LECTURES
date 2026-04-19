namespace Week_7_1_OOP_Exercises_2.Inheritance;

public class Employee
{
    private string _id;
    private string _name;
    protected string _position;

    public Employee(string id, string name)
    {
        _id = id;
        _name = name;
        _position = "Standart Employee";
    }

    private const int BASE_SALARY = 1000;
    
    public virtual int GetSalary()
    {
        return BASE_SALARY;
    }
}