using Week5_1_Classes;

public class Program
{
    public static void Main(string[] args)
    {
        
        

        //  ( 5/6)  (2/3)   = 

        int[] wiladi1 = [5, 6];
        int[] wiladi2 = [2, 3];

        Rational rational = new Rational(5, 6);  // 5/6

        Console.WriteLine(rational.Numerator);
        Console.WriteLine(rational.Denominator);
        
        
        rational.Print();
        
        
       
        
        // int[] wiladi = Add(wiladi1, wiladi2);
        // Print(wiladi);

        Rational a = new Rational(2, 3);
        Rational b = new Rational(5, 6);


        Rational aPlusb = Add(a, b);

        Console.WriteLine(aPlusb.Numerator);  // 27
        Console.WriteLine(aPlusb.Denominator); // 18
        
        aPlusb.Print();
        
        aPlusb.Simplify();
        
        aPlusb.Print();


        Rational c = a.Add(b);  // a + b
        c.Print();



        Rational d = new Rational(3, 4);
        Rational d1 = new Rational(1, 2);
        
        d.Sub(d1).Print();
        
        d.Mul(d1).Print();
        
        d.Div(d1).Print();

        Rational max = Rational.Max(a, b);
        
        
        int result = a.CompareTo(b); // 0  123  -123
        

    }

    // 
    public static int[] Add(int[] a, int[] b)
    {
        return [a[0] * b[1] + b[0] * a[1], a[1] * b[1]];
    }

    public static void Print(int[] wiladi)
    {
        Console.WriteLine($"mricxveli: {wiladi[0]} , mnishvneli {wiladi[1]}");
    }

    // 2/3   5/6 = 27/18   =  3/2 
    public static Rational Add(Rational a, Rational b)
    {
        Rational result = new Rational(a.Numerator * b.Denominator + b.Numerator * a.Denominator, a.Denominator * b.Denominator);
        return result;
    }

}