namespace Week_7_1_OOP_Exercises_2.Inheritance;

public class A
{
    private int _a;

    public A(int a)
    {
        _a = a;
    }
    
    public virtual int GetSomething() => _a;
}