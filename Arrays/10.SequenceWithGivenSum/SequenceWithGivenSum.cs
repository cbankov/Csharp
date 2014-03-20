using System;
using System.Collections.Generic;

class MostFrequent
{
    static void Main()
    {
        Console.Write("Enter size of raw: ");
        int n = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];
        for (int index = 0; index < myArray.Length; index++)
        {
            Console.Write("Enter  element {0} of the raw: ",index+1);
            myArray[index] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter K element: ");
        int k = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = i; j < myArray.Length; j++)
            {
                sum += myArray[j];

                if (sum == k)
                {
                    Console.Write(k+"=(");
                    for (int x = i; x <= j; x++)
                    {
                        Console.Write(myArray[x]+"+");
                    }
                    Console.Write("\b) ");
                }
            }
            sum = 0; 
        }

    }

}
