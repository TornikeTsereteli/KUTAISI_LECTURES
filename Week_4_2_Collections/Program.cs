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

        list = [22, 3, 3, 32, 3, 22, 22];
        Print(list);
        RemoveDuplicates(list);
        Print(list);
        
        Console.WriteLine("EncodeLength");
        List<string> encodedList = EncodeLength(["a", "a","a", "b", "b", "c", "a","a","a"]);
        Console.WriteLine("[" + string.Join(", ", encodedList) + "]");
        
        
        HashSet<int> set = new HashSet<int>();
        set.Add(1);
        set.Add(2);
        set.Add(2);

        Console.WriteLine(string.Join(", ", set));
        ;
        
    }

    public static void Print(List<int> list)
    {
        Console.Write("["+string.Join(", ", list));
    }

    public static List<int> RemoveD(List<int> list)
    {
        return list.ToHashSet().ToList();
    }
    
    public static void RemoveDuplicates(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < list.Count; j++)
            {
                if (i != j && list[i] == list[j])
                {
                    list.RemoveAt(j);
                    j--;
                }
            }
        }
    }
    
    // ['a', 'a', 'b', 'b' , 'c', 'a'] => ['a2', 'b2', 'c1', a1]'
    public static List<string> EncodeLength(List<string> list)
    {
        List<string> result = new List<string>();
        int i = 0;
        int count = 1;
        while (i < list.Count - 1)
        {
            if (list[i] == list[i + 1])
            {
                count++;
                i++;
            }
            else
            {
                result.Add(list[i] + count);
                count = 1;
                i++;
            }
        }
        result.Add(list[i] + count);
        return result;
    }
    
    // [1,2,2,3,4,5,6] , [2,3,4,5] -> [2,3,4,5]
    public static List<int> FindSameElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set = new HashSet<int>();
        foreach (int element in list1)
        {
            set.Add(element);
        }

        foreach (var element in list2)
        {
            set.Add(element);
        }
        
        return set.ToList();
        
    }
    
    
    
    
}