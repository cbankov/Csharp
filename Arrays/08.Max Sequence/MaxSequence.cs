using System;

class SumSInArray
{
    static void Main()
    {
        Console.Write("Array length:");
        int length = int.Parse(Console.ReadLine());

        Console.Write("S:");
        int s = int.Parse(Console.ReadLine());
        int[] arr = new int[length];

        //array input
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("[{0}]=", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        //the algorithm        
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                sum += arr[j];
                if (sum == s)
                {
                    Console.Write(s + "={");              //the output sequence
                    for (int k = i; k <= j; k++)        //
                    {                                   //
                        Console.Write(arr[k] + ",");      //                  
                    }                                   //
                    Console.WriteLine("\b}");           //
                }
            }
            sum = 0;
        }
    }
}