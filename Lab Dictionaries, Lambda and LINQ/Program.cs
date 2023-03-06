using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab_Dictionaries__Lambda_and_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Dictionary<int, int> myDictionary = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!myDictionary.ContainsKey(numbers[i]))
                {
                    myDictionary.Add(numbers[i], 0);
                }
                myDictionary[numbers[i]]++;
            }
                //Dictionary<int,int> orderedDictionary = myDictionary.OrderBy(x => x);

            foreach (var kvp in myDictionary.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
