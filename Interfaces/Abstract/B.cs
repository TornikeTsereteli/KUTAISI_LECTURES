namespace Interfaces.Abstract;

public class B : A
{
    public B(string name, string lastName) : base(name, lastName)
    {
    }

    public override void Method()
    {
        Console.WriteLine("HELLO B");
    }
}