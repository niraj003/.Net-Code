Write a program to create two HashSets with integer dataand simulate the following functions:
1) Intersection 
2) Union
3) ExceptWith
(Do not use the inbuilt functions provided for them) 

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create HashSet 1
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };

        // Create HashSet 2
        HashSet<int> set2 = new HashSet<int> { 2, 3, 4 };

        // Simulate Intersection without inbuilt functions
        HashSet<int> intersection = SimulateIntersection(set1, set2);

        // Simulate Union without inbuilt functions
        HashSet<int> union = SimulateUnion(set1, set2);

        // Simulate ExceptWith without inbuilt functions
        SimulateExceptWith(set1, set2);

        // Display the results
        Console.WriteLine("HashSet 1: {" + string.Join(", ", set1) + "}");
        Console.WriteLine("HashSet 2: {" + string.Join(", ", set2) + "}");
        Console.WriteLine("Intersection: {" + string.Join(", ", intersection) + "}");
        Console.WriteLine("Union: {" + string.Join(", ", union) + "}");
        Console.WriteLine("HashSet 1 after ExceptWith: {" + string.Join(", ", set1) + "}");
    }

    static HashSet<int> SimulateIntersection(HashSet<int> set1, HashSet<int> set2)
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

    static HashSet<int> SimulateUnion(HashSet<int> set1, HashSet<int> set2)
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

    static void SimulateExceptWith(HashSet<int> set1, HashSet<int> set2)
    {
        foreach (var item in set2)
        {
            set1.Remove(item);
        }
    }
}