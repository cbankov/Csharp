using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphabetindex
{
    class alpha             
    {
        static void Main()
        {
            int[] letters = new int[26];

          
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = 'a' + i;
            }
            string n = Console.ReadLine();

            for (int i = 0; i < n.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (n[i] == letters[j])
                    {
                        Console.WriteLine(j+1);
                        break;
                    }
                }
                
            }


        }
    }
}
