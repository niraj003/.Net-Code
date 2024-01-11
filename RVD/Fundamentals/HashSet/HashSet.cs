Write a program to create two HashSets with integer dataand simulate the following functions:
1) Intersection 
2) Union
3) ExceptWith
(Do not use the inbuilt functions provided for them) 


using System;
using System.Collections.Generic;


public class HelloWorld
{
    public static void Main(string[] args)
    {
      HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
      HashSet<int> set2 = new HashSet<int> { 2, 3, 4 };
      
      HashSet<int> intersection = Intersection(set1, set2);
      HashSet<int> union = Union(set1, set2);
      ExceptWith(set1, set2);
      Console.WriteLine("HashSet 1: {" + string.Join(", ", set1) + "}");
      Console.WriteLine("HashSet 2: {" + string.Join(", ", set2) + "}");
      Console.WriteLine("Intersection: {" + string.Join(", ", intersection) + "}");
      Console.WriteLine("Union: {" + string.Join(", ", union) + "}");
      Console.WriteLine("HashSet 1 after ExceptWith: {" + string.Join(", ", set1) + "}");
    }
     static HashSet<int> Intersection(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> intersection = new HashSet<int>();

        foreach (var item in set1)
        {
            if (set2.Contains(item))
            {
                intersection.Add(item);
            }
        }

        return intersection;
    }

    static HashSet<int> Union(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> union = new HashSet<int>(set1);

        foreach (var item in set2)
        {
            if (!union.Contains(item))
            {
                union.Add(item);
            }
        }

        return union;
    }

    static void ExceptWith(HashSet<int> set1, HashSet<int> set2)
    {
        foreach (var item in set2)
        {
            set1.Remove(item);
        }
    }
}
