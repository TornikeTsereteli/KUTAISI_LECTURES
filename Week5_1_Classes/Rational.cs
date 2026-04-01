using System.Runtime.InteropServices;

namespace Week5_1_Classes;

public class Rational
{
    public int Numerator;  // 27  = 3
    public int Denominator; // 18 = 2

    public Rational(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }


    public void Print()
    {
        Console.WriteLine($"{Numerator}/{Denominator}");
    }

    // 27 / 18  = 3/2  gcd = GCD(27,18)    27/a   18/a  =  3/2
    public void Simplify()
    {
        int a = GCD(Numerator, Denominator); // 27 18  -> 9
        Numerator /= a;
        Denominator /= a;
    }

    public Rational Add(Rational rational)
    {
        int numerator = this.Numerator * rational.Denominator + rational.Numerator * this.Denominator;
        int denominator = this.Denominator * rational.Denominator;
        Rational result = new Rational(numerator, denominator);
        result.Simplify();
        return result;
    }

    public Rational Sub(Rational rational)
    {
        int numerator = this.Numerator * rational.Denominator - rational.Numerator * this.Denominator;
        int denominator = this.Denominator * rational.Denominator;
        Rational result = new Rational(numerator, denominator);
        result.Simplify();
        return result;
    }
    //
    public Rational Mul(Rational rational)
    {
        int num = this.Numerator * rational.Numerator;
        int denom = this.Denominator * rational.Denominator;
        Rational result = new Rational(num, denom);
        result.Simplify();
        return result;
    }

    public Rational Div(Rational rational)
    {
        int num = this.Numerator * rational.Denominator;
        int denom = this.Denominator * rational.Numerator;
        Rational result = new Rational(num, denom);
        result.Simplify();
        return result;
    }


    public static Rational Max(Rational a, Rational b)
    {
        int num1 = a.Numerator * b.Denominator;
        int num2 = b.Numerator * a.Denominator;
        return num1 > num2 ? a : b;
    }
    
    
    public static Rational Min(Rational a, Rational b)
    {
        int num1 = a.Numerator * b.Denominator;
        int num2 = b.Numerator * a.Denominator;
        return num1 < num2 ? a : b;
    }

        // a < b return negative number
        // a==b  return 0
        // a > b return positive number
    public int CompareTo(Rational b)
    {
        int num1 = this.Numerator * b.Denominator;
        int num2 = b.Numerator * this.Denominator;

        if (num1 == num2)
        {
            return 0;
        }

        if (num1 < num2)
        {
            return -1;
        }
        else
        {
            return 1;
        }
    }
    private static int GCD(int a, int b)  // 27, 18     1-18
    {
        int result = 1;
        for (int i = 2; i <= int.Min(a, b); i++)
        {
            if (a % i == 0 && b % i == 0)
            {
                result = i;
            }
        }
        return result;
        
        // 10 6 //  4 6 // 4 2 // 2 2
        // while (a != b)
        // {
        //     if (a < b)
        //     {
        //         b = b - a;
        //     }
        //     else
        //     {
        //         a = a - b;
        //     }
        // }
        // return a;
    }



}