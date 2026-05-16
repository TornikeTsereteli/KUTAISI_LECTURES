namespace Interfaces.Abstract;

public abstract class A
{
    public string Name { get;set; }
    public string LastName { get; set; }


    public A(string name, string lastName)
    {
        this.Name = name;
        this.LastName = lastName;
    }


    public void G()
    {
        Console.WriteLine("Hello A");
    }
    
    public abstract void Method();
}