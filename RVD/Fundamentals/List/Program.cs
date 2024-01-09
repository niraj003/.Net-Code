// See https://aka.ms/new-console-template for more information

using System.Collections.Generic; 
using System;
using System.Linq;

namespace List // Note: actual namespace depends on the project name.
{   
   
    internal class Program
    {
         public static void PrintList(List<string> l1){
            foreach (var item in l1)
            {
                Console.WriteLine(item);
            }
        
    }
        static void Main(string[] args)
        {
           List<string> l1 = new List<string>(){"xyz","abc","niraj","raj","yesh","meet","n","ghetiya"};
           Console.WriteLine("Befor Sort:");
           PrintList(l1);
           l1.Sort((a,b)=>a.Length.CompareTo(b.Length));
           Console.WriteLine("\nAfter Sort:");
           PrintList(l1);

        }
    }
}