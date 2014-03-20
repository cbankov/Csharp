﻿using System;
using System.Collections.Generic;

class TheMostFrequentnumber
{
    static void Main()
    {
        Console.WriteLine("Enter size of raw");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int index = 0; index < numbers.Length; index++)
        {
            Console.WriteLine("Enter elements");
            numbers[index] = int.Parse(Console.ReadLine());
        }
        int mostFrequent = 0;
        int times = 0;
 
        IDictionary<int, int> numberFrequency = new Dictionary<int, int>();
 
        foreach (int number in numbers)
        {
            if (!numberFrequency.ContainsKey(number))
            {
                numberFrequency.Add(number, 1);
            }
            else
            {
                ++numberFrequency[number];
            }
        }
 
        foreach (KeyValuePair<int, int> pair in numberFrequency)
        {
            if (pair.Value > times)
            {
                times = pair.Value;
                mostFrequent = pair.Key;
            }
        }
        Console.WriteLine("{0} ({1} times)", mostFrequent, times);
    }
}