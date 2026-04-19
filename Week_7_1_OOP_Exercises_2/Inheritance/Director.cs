namespace Week_7_1_OOP_Exercises_2.Inheritance;

public class Director : Employee
{
    public Director(string id, string name) : base(id, name)
    {
        base._position = "Director";
    }
    
    public override int GetSalary()
    {
        return base.GetSalary() * 6;
    }

    public void MakeMovie()
    {
        
    }
}