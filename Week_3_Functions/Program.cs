public class Program
{

    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        
        
        Console.WriteLine(Max(1,2));
        Console.WriteLine(MaxElementInArray(arr));
        
        PrintArray(arr);
        
        
        
        
        
        
        
        // Reverse [1,2,3,4,5] -> [5,4,3,2,1]
        // Sum   [1,2,3,4,5] -> 15
        // Average [1,2,3,4,5] -> 3
        // factorial 5 -> 120
        // search 
        
    }

    public static int[] Reverse(int[] arr)
    {
        
        
        return [];
    }
    
    public static int Max(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    public static int MaxElementInArray(int[] arr)
    {
        int max = arr[0];
        for(int i = 0; i < arr.Length; i++)
        {
            max = Max(max, arr[i]);
        }
        return max;
    }
    

    public static void PrintArray(int[] arr)
    {
        // [1,2,3,4,5] ","  [ 1, 2, 3, 4, 5 ]
        Console.WriteLine("[ " + string.Join(", ", arr)+" ]");
        
    }
    
}