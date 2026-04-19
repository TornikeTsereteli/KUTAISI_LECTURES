namespace Week_7_1_OOP_Exercises_2.Inheritance;

public class Manager : Employee
{
    private const int _bonus = 500;
    public Manager(string id, string name) : base(id, name)
    {
        base._position = "Manager";
    }
    public int GetSalary()
    {
        return base.GetSalary() * 2 + _bonus;
    }
}