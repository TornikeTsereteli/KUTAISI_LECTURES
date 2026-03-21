public class Program
{
    public static void Main()
    {
        //  collections
        
        // array  
        
        int[] arr = {1, 2, 3, 4, 5};
        
        // list 
        List<int> list = new List<int>();
        
        list.Add(123);
        list.Add(6);
        list.Add(7);
        list.Add(7);
        list.Add(8);
        list.Add(8);


        Console.WriteLine("Print By foreach loop");
        foreach (int element in list)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine("Print By for loop");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        list.Remove(7);
        // list.RemoveAll(x => x > 0);
        Console.WriteLine();
        foreach (int element in list)
        {
            Console.WriteLine(element);
        }
        list.Sort();
        Print(list);
        list.Reverse();
        Print(list);
        list.Insert(3,124);
        Print(list);
        list.RemoveAt(3);
        Print(list);
        Console.WriteLine(list.Contains(8));
        
    }

    public static void Print(List<int> list)
    {
        Console.Write("[");
        Console.Write(string.Join(", ", list));
        Console.WriteLine("]");
    }
    
    public static void RemoveDuplicates(List<int> list)
    {
        
    }
    // ['a', 'a', 'b' 'b' , 'c'] => ['a2', 'b2', 'c1']'
    public static void EncodeLength(List<int> list)
    {
        
    }
}