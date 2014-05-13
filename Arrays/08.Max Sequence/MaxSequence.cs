using System;

class PrintLetterIndex
{
    static void Main()
    {
        char[] arr = new char[26];
        string word = (Console.ReadLine().ToLower());

        for (int i = 0; i < 26; i++)
        {
            arr[i] = Convert.ToChar('a' + i);
        }

        for (int J = 0; J < word.Length; J++)
        {
            Console.WriteLine("{0} [{1}]", word[J], word[J] - 'a');
        }
    }
}
