using System;

class SequenceMaxSum
{
    static void Main()
    {
        Console.Write("Number of elements in the array ( N ) ?  ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        while (n < 4)
        {
            Console.Write("Number of elements in the array should be at least 4 !  ");
            n = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element " + (i + 1) + " of the array? ");
            array[i] = int.Parse(Console.ReadLine());
        }
        int max = 0;
        int sum = array[0] + array[1] + array[2] + array[3];
        int temp;
        for (int i = 0; i < n - 3; i++) //one loop
        {
            temp = array[i] + array[i + 1] + array[i + 2] + array[i + 3];
            if (sum < temp)
            {
                sum = temp;
                max = i;
            }
        }
        Console.WriteLine(array[max] + ", " + array[max + 1] + ", " + array[max + 2] + ", " + array[max + 3]);
    }
}