using System.Runtime.InteropServices;

namespace Week5_1_Classes;

public class Rational
{
    public int Numerator;  // 27  = 3
    public int Denominator; // 18 = 2

    public Rational(int numerator, int denominator)
    {
        this.Numerator = numerator;
        this.Denominator = denominator;
    }

    

    public void Print()
    {
        Console.WriteLine($"{Numerator}/{Denominator}");
    }
    // 27/18 = 3/2
    public void Simplify()
    {
        int gcd = GCD(Numerator, Denominator);
        this.Numerator = this.Numerator / gcd;
        this.Denominator = Denominator / gcd;
    }

    public Rational Add(Rational r)
    {
        int numerator = this.Numerator * r.Denominator + r.Numerator * this.Denominator;
        int denominator = this.Denominator * r.Denominator;
        Rational result = new Rational(numerator, denominator);
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
        List<int> divisorsOfA = [];
        for (int i = 1; i <= a; i++)
        {
            if (a % i == 0)
            {
                divisorsOfA.Add(i);
            }
        }

        List<int> divisorsOfB = [];
        for (int i = 1; i <= b; i++)
        {
            if (b % i == 0)
            {
                divisorsOfB.Add(i);
            }
        }

        List<int> commonDivisors = [];
        foreach (var divisor in divisorsOfA)
        {
            if (divisorsOfB.Contains(divisor))
            {
                commonDivisors.Add(divisor);
            }
        }

        return commonDivisors.Max();
    }

    public static int GCD2(int a, int b)
    {
        // a b  -> a - b,  a==b
        while (a!=b)
        {
            if (a > b)
            {
                a = a - b;
            }
            else
            {
                b = b - a;
            }
        }
        return a;
    } 
    



}