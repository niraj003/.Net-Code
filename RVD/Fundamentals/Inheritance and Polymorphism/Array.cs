using System;

class Array
{
    private int[] arr;

    public Array(int size)
    {
        arr = new int[size];
    }

    public void readElements()
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Enter element at index " + i + ": ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public void displayElements()
    {
        Console.WriteLine("The elements in the array are: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}