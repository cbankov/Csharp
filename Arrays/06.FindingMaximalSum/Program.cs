﻿using System;
using System.Collections.Generic;

class MostFrequent
{
    static void Main()
    {
        Console.WriteLine("Enter size of raw");
        int n = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];
        for (int index = 0; index < myArray.Length; index++)
        {
            Console.WriteLine("Enter elements of the raw");
            myArray[index] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter K element");
        int k = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = 0; j < myArray.Length; j++)
            {
                sum += myArray[j];

                if (sum == k)               
                {
                    for (int x = i; x <= j; x++)            //
                    {                                   //
                        Console.Write(myArray[x] + ",");      //                  
                    }

                }
            }

        }

    }

}
