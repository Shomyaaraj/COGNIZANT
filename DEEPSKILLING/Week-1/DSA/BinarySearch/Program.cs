using System;

class Program
{
    static void Main()
    {
        int[] arr = {10,20,30,40,50};

        int key = 30;

        int low = 0;
        int high = arr.Length - 1;

        while(low<=high)
        {
            int mid = (low+high)/2;

            if(arr[mid]==key)
            {
                Console.WriteLine("Element Found");
                return;
            }
            else if(arr[mid]<key)
                low = mid + 1;
            else
                high = mid - 1;
        }

        Console.WriteLine("Element Not Found");
    }
}