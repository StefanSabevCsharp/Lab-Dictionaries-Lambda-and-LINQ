using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> count = new Dictionary<string, int>();

            foreach (string word in input)
            {
                string currentWord = word.ToLower();

                if (!count.ContainsKey(currentWord))
                {
                    count.Add(currentWord, 0);
                }
                count[currentWord]++;
            }

            foreach (var kvp in count)
            {
                if (kvp.Value % 2 != 0)
                {
                    Console.Write(kvp.Key + " ");
                }
            }
        }
    }
}
