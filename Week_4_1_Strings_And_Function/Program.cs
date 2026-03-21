using System.Reflection.PortableExecutable;

public class Program
{
    public static void Main(string[] args){
        //  2. ინდექსაცია
        // 3. Length
        // string-ის შეცვლა (immutable იდეა)
        // ძირითადი მეთოდები  ToUpper / ToLower Contains  StartsWith / EndsWith StartsWith / EndsWith  Split
        // პრაქტიკული ამოცანები:
        //
        string s = "Hello World";  //H   // s[0]  s[1] s[2] s[3] s[4] s[5] s[6] s[7] s[8]
        int a = 5;
        
        Console.WriteLine(s[0]); // s[1]

        Console.WriteLine(s[1]);

        int cnt = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsDigit(s[i]))
            {
                cnt++;
            }
        }

        Console.WriteLine(cnt);


     


        // s[0] = '1';  compile error


        string tolowerCase = s.ToLower(); //HELLo -> hello

        Console.WriteLine(tolowerCase);
        Console.WriteLine(s.ToUpper());  // hello -> HELLO

        Console.WriteLine(s.Contains("World"));  //  Hello World -> true

        Console.WriteLine(s.StartsWith("Hello"));

        Console.WriteLine(s.EndsWith("World"));
        
        string[] split = s.Split(' ');  // hello world -> [hello, world]
        string[] split1 = s.Split(' ');  // hello world 123 -> [hello, world, 123]

        string ss = "hello,world,world2,123"; // -> [hello,world,world2,123]
        string[] splitByComma = ss.Split(',');

        Console.WriteLine(splitByComma[2]);
        
        
        Console.WriteLine(" hello   eq  ".Trim()); // 
        




        
        // count vowels
        // count words
        // remove spaces // " "
        // remove numbers
        // remove punctuations

        Console.WriteLine(s.Replace("o", "0")); // 

      

        int[] arr = [1, 2, 4, 5];
        ChangeArray(arr);
        Console.WriteLine(arr[0]); // რა დაიბეჭდება

        int x = 5;
        ChangeInteger(x);
        Console.WriteLine(x); // 5
        arr = [1, 2, 34, 53];
        ChangeArray2(arr);
        Console.WriteLine(arr[0]); // 1 tu 99
        
        change(ref x);
        Console.WriteLine(x);

        if (!int.TryParse("123a", out int result))
        {
        };
        
        Greet("John");
        
        Greet("John", "Hi");
        
    }
    // fact(5) = 5 * fact(4) = 5 * 4 * fact(3) = 5*4*3* fact(2) = 5*4*3*2 *fact(1)
    public static int Factorial(int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }
    // fact(5) = 5 * fact(4) = 5 * 4 * fact(3) = 5*4*3* fact(2) = 5*4*3*2 *1 = 120;

    
  

    public static void change(ref int x)
    {
        Console.WriteLine();
    }

    public static void change2(int x, out int result)
    {
        result = 1;
    }
    
    public static void ChangeArray(int[] arr)
    {
        arr[0] = 10;
    }
    public static void ChangeInteger(int x)
    {
        x = x + 1;
    }
    public static void ChangeArray2(int[] arr)
    {
        arr = new int[2];
        arr[0] = 99;
    }
    
    
    public static int Min(int x, int y)
    {
        return x + y;
    }
    public static int Min(int x, int y, int z)
    {
        return x + y + z;
    }
    public static int Min(int x, int y, int z, int a)
    {
        return x + y + z;
    }

    public static void Greet(string name, string greetText = "Hello")
    {
        Console.WriteLine(greetText + " " + name);
    }

    
    
    
    
    static void Change(ref int x)
    {
        x = 10;
    }

    public static int CountVowels(string s)
    {
        s = s.ToLower();
        int cnt = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if(s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] =='o' || s[i] == 'u')
            {
                cnt++;
            }
        }
        return cnt;
    }

    public static int CountWords(string s)  // "  hello world   " -> 2
    {
        return s.Trim().Split(' ').Length;
    }
    
    public static string RemoveSpaces(string s)
    {
        return s.Replace(" ", "");
    }

    public static string RemoveNumbers(string s)
    {
        for (int i = 0; i < 10; i++)
        {
            s = s.Replace(i.ToString(), "");
        }
        return s;
    }

    public static string RemovePunctuations(string s)
    {
        return s.Replace(",", "");
    }
    
    
}