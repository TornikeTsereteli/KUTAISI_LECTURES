using Week5_1_Classes;

public class Program
{
    public static void Main(string[] args)
    {
        // Rational rational1 = new Rational(5, 6);
        //
        // Console.WriteLine($"numerator is {rational1.Numerator}");
        //
        // //  ( 5/6)  (2/3)   = 
        //
        // int[] wiladi1 = [5, 6];
        // int[] wiladi2 = [2, 3];
        //
        //
        // string person1_name = "john";
        // int person1_age = 20;
        //
        // string person2_name = "jane";
        //
        // Rational rational = new Rational(5, 6);  // 5/6
        //
        // Console.WriteLine(rational.Numerator);
        // Console.WriteLine(rational.Denominator);
        //
        //
        // rational.Print();
        //
        //
        // int[] array = [1, 1, 2, 414];
        //
        //
        //
        //
        // // int[] wiladi = Add(wiladi1, wiladi2);
        // // Print(wiladi);
        //
        // Rational a = new Rational(2, 3);
        // Rational b = new Rational(5, 6);
        //
        //
        // Rational aPlusb = Add(a, b);
        //
        // Console.WriteLine(aPlusb.Numerator);  // 27
        // Console.WriteLine(aPlusb.Denominator); // 18
        //
        // aPlusb.Print();
        //
        // aPlusb.Simplify();
        //
        // aPlusb.Print();
        //
        //
        // Rational c = a.Add(b);  // a + b
        // c.Print();
        //
        //
        //
        // Rational d = new Rational(3, 4);
        // Rational d1 = new Rational(1, 2);
        //
        // d.Sub(d1).Print();
        //
        // d.Mul(d1).Print();
        //
        // d.Div(d1).Print();
        //
        // Rational max = Rational.Max(a, b);
        //
        //
        // int result = a.CompareTo(b); // 0  123  -123
        //
        //
        //
        //
        // Rational r = new Rational(1, 2);
        // Rational s = new Rational(2, 3);
        //
        // Rational sum = Add(r, s);
        // sum.Print();



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
    // 2/3 5/6 = 27/18
    public static Rational Add(Rational a, Rational b)
    {
        int numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
        int denominator = a.Denominator * b.Denominator;
        Rational result = new Rational(numerator, denominator);
        return result;
    }

    public static Rational Sub(Rational a, Rational b)
    {
        int numerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
        int denominator = a.Denominator * b.Denominator;
        Rational result = new Rational(numerator, denominator);
        return result;
    }

    public static Rational Mul(Rational a, Rational b)
    {
         int numerator = a.Numerator * b.Numerator;
         int denominator = a.Denominator * b.Denominator;
         Rational result = new Rational(numerator, denominator);
         return result;
    }
 
    public static Rational Div(Rational a, Rational b)
    {
         return Mul(a, new Rational(b.Denominator, b.Numerator));
    }
    
}