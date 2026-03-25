public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        
        dict.Add("person 1", 18);

        dict["person 2"] = 20;

        Console.WriteLine(dict["person 1"]);

        Console.WriteLine(dict["person 2"]);

        foreach (var item in dict)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }

        foreach (var item in dict.Keys)
        {
            Console.WriteLine(dict[item]);
        }

        Console.WriteLine(dict.ContainsKey("person 1"));

        
        List<int> list = [1,2,1,1,1,2,3];

        string s = null;
        
        int? result = FirstDuplicatedValue(list);
        Console.WriteLine(result);
        if (FirstDuplicatedValue(list, out int res))
        {
            Console.WriteLine(res);
        }

      

    }
    // [1,2,1,1,1,2,3] -> [1,2]
    public static HashSet<int> FindDuplicates(List<int> list)
    {
       HashSet<int> result = new HashSet<int>(); // [] -> [1] -> [1,2]
       HashSet<int> set = new HashSet<int>(); // [] -> [1] -> [1,2] -> [1,2,3]
       foreach (var item in list)
       {
           if (set.Contains(item)) 
           {
               result.Add(item);
           }
           set.Add(item); // 
       }
       return result;
    }
    // [1,2,3] , [4,5,6] -> [1,2,3,4,5,6]
    public static List<int> Merge(List<int> list1, List<int> list2)
    {
        List<int> result = new List<int>();
        int i = 0;
        int j = 0;
        while (i < list1.Count && j < list2.Count)
        {
            if (list1[i] < list2[j])
            {
                result.Add(list1[i]);
                i++;
            }
            else
            {
                result.Add(list2[j]);
                j++;
            }
        }

        if (i < list1.Count)
        {
            result.AddRange(list1.GetRange(i, list1.Count - i));
        }
        if (j < list2.Count)
        {
            result.AddRange(list2.GetRange(j, list2.Count - j));
        }

        return result;

    }

    // წაშალეთ მინიმალური ელემენტი
    public static void RemoveMin(List<int> list)
    {
        int min = list.Min();
        list.RemoveAll(x => x == min);
    }
    // [1,2,3,4,5] -> [1,3,6,10,15];
    public static List<int> PrefixSum(List<int> list)
    {
        int currentSum = 0;
        List<int> result = new List<int>();
        foreach (var item in list)
        {
            currentSum += item;
            result.Add(currentSum);
        }
   
        return result;
    }
    // HashSets 
    
        // "abc" -> true
        // "abcc" -> false
        // abc d e-> false
    public static bool IsUniqueSymbols(string s)
    {
        // HashSet
        HashSet<char> set = new HashSet<char>();
        foreach (var item in s)
        {
            if (set.Contains(item))
            {
                return false;
            }
            set.Add(item);
        }
        return true;
    }

    public static int? FirstDuplicatedValue(List<int> list)
    {
        HashSet<int> set = new HashSet<int>();
        foreach (var item in list)
        {
            if (!set.Add(item))
            {
                return item;
            }
        }
        return null;
    }
    
    public static bool FirstDuplicatedValue(List<int> list, out int result)
    {
        HashSet<int> set = new HashSet<int>();
        foreach (var item in list)
        {
            if (!set.Add(item))
            {
                result = item;
                return true;
            }
        }
        result = 0;
        return false;
    }

    // [1,2,2,3,4,5,6] , [2,3,4,5] -> [1,6]
    public static List<int> FindDifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = list1.ToHashSet();
        HashSet<int> set2 = list2.ToHashSet();

        List<int> result = new List<int>();
        foreach (var item in set1)
        {
            if (!set2.Contains(item))
            {
                result.Add(item);
            }
        }
        return result;
    }
    // "agramaan" , "nagaram" -> true
    // "aaabb" "bbaab" -> false
    public static bool IsAnagram(string s1, string s2)
    {
        if (s1.Length != s2.Length)
        {
            return false;
        }
        Dictionary<char, int> dict = new Dictionary<char, int>();
        // dict.ContainsKey();
        // dict['a'] = 9;
        // dict['b']
        foreach (var c in s1)
        {
            if (dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict[c] = 1;
            }
        }

        foreach (var c in s2)
        {
            if (dict.ContainsKey(c))
            {
                dict[c]--;
            }
        }

        return dict.All(x => x.Value == 0);
    }
    // [1,2,3,4,5] , 7 -> [2,3],                 [1,4]
    public static int[] TwoSum(List<int> list, int target)
    {
        // Use Dictionary
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for (int i = 0; i < list.Count; i++)
        {
            if (dict.ContainsKey(target - list[i]))
            {
                return [i, dict[target - list[i]]];
            }
            dict[list[i]] = i;
        }
        return [];
    }

    // ["abx", "ab", "abc", "abz"] -> {3: [abx,abc,abz], 2: [ab] }
    public static Dictionary<int, List<string>> GroupByLength(List<string> list)
    {
        Dictionary<int, List<string>> dict = new Dictionary<int, List<string>>();
        foreach (var item in list)
        {
            if (dict.ContainsKey(item.Length))
            {
                dict[item.Length].Add(item);
            }
            else
            {
                dict[item.Length] = [item];
            }
        }
        return dict;
    }
    
}