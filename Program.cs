using System;

class dsddas
{
    static void Main()
    {
        Console.WriteLine("enter legth of the arrays");
        int arrays = int.Parse(Console.ReadLine());

        int[] firstar = new int[arrays];
        int[] secondar = new int[arrays];

        Console.WriteLine("Enter numbers for first array: ");
        for (int i = 0; i < arrays; i++)
        {
            firstar[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter numbers for second array: ");
        for (int i = 0; i < arrays; i++)
        {
            secondar[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arrays; i++)
        {
            if (firstar[i] == secondar[i])
            {
                Console.WriteLine("{0} = {1}", firstar[i], secondar[i]);
            }
            if (firstar[i] < secondar[i])
            {
                Console.WriteLine("{0} < {1}", firstar[i], secondar[i]);
            }
            if (firstar[i] > secondar[i])
            {
                Console.WriteLine("{0} > {1}", firstar[i], secondar[i]);
            }

        }

        bool check = true;

        for (int i = 0; i < arrays; i++)
        {
            if (firstar[i] != secondar[i])
            {
                check = false;
                break;
            }
        }

        if (check == true)
        {
            Console.WriteLine("Same!");
        }
        else
        {
            Console.WriteLine("Arrays not the same");
        }
    }
}
