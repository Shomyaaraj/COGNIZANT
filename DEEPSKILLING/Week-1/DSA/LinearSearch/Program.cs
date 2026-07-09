using System;

class Program
{
    static void Main()
    {
        int[] arr = {5,10,15,20,25};

        int key = 20;

        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i]==key)
            {
                Console.WriteLine("Element Found at index " + i);
                return;
            }
        }

        Console.WriteLine("Element Not Found");
    }
}