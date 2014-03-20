

using System;
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
            Console.WriteLine("Enter elements");
            myArray[index] = int.Parse(Console.ReadLine());
        }
        Dictionary<int, int> mostFrequnet = new Dictionary<int, int>();
        int bestElement = 0;
        int bestFrequnecy = int.MinValue;
        for (int i = 0; i < myArray.Length; i++)
        {
           
            int tempValue;
            if (mostFrequnet.TryGetValue(myArray[i], out tempValue))
            {
                mostFrequnet[myArray[i]] = tempValue + 1;
            }
            else
            {
                mostFrequnet.Add(myArray[i], 1);
            }
        }
        foreach (var item in mostFrequnet)
        {
            if (item.Value > bestFrequnecy)
            {
                bestElement = item.Key;
                bestFrequnecy = item.Value;
            }
        }
        Console.WriteLine("The number {0} shows {1} times", bestElement, bestFrequnecy);
    }
}