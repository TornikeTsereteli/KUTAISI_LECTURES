namespace Week_7_1_OOP_Exercises_2.Inheritance;

public class B : A
{

    private int _b;
    private int _c;
    private int _d;
    public B(int b, int c, int d) : base(b)
    {   
        this._b = b;
        this._c = c;
        this._d = d;
    }

    public B(int b, int c) : this(b, c, 0)
    {
        
    }

    public override int GetSomething()
    {
        return _b + 123;
    }
}