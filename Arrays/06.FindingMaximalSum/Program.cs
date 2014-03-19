using System;

class test
{
    static void Main()
    {
        Console.WriteLine("enter K number: ");
        int k = int.Parse(Console.ReadLine());  
        Console.WriteLine("Enter N number: ");
        int n = int.Parse(Console.ReadLine());  
        int [] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter arr elements: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        int sum = 0;
        Console.WriteLine("Elements are: ");
        for (int i = arr.Length - 1; i >= arr.Length - k; i--)
        {
            sum += arr[i];
            Console.WriteLine(arr[i]+" ");
        }
        Console.WriteLine("Sum is {0}", sum);

    }
}
