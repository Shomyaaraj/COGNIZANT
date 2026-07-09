using System;

class Program
{
    static void Main()
    {
        int[] arr = {10,20,30,40,50};

        Console.WriteLine("Array Elements:");

        foreach(int i in arr)
        {
            Console.Write(i + " ");
        }
    }
}