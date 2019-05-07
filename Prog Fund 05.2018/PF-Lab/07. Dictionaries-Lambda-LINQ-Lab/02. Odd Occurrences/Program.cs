using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split();

            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (!words.ContainsKey(word))
                {
                    words.Add(word,0);
                }
                words[word]++;
            }

            List<string> oddCountWords = new List<string>();

            foreach (var pair in words)
            {
                if (pair.Value%2==1)
                {

                    oddCountWords.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ",oddCountWords));
        }
    }
}
