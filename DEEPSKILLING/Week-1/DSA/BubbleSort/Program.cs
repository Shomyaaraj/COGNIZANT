using System;

class Program
{
    static void Main()
    {
        int[] arr = {5,2,8,1,9};

        for(int i=0;i<arr.Length-1;i++)
        {
            for(int j=0;j<arr.Length-i-1;j++)
            {
                if(arr[j]>arr[j+1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted Array:");

        foreach(int i in arr)
        {
            Console.Write(i + " ");
        }
    }
}