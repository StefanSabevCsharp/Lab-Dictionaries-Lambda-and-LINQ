using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
                int n = int.Parse(Console.ReadLine());
                Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();
                if (!dict.ContainsKey(word))
                {
                    List<string> currentList = new List<string>();
                    dict.Add(word, currentList);
                }
                dict[word].Add(synonim);

            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ",kvp.Value)}");
            }
        }
    }
}
