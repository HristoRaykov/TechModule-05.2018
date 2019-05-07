using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiter = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            string[] input = Console.ReadLine().Split(delimiter,StringSplitOptions.RemoveEmptyEntries);

            List<string> lowerCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();
            


            for (int i = 0; i < input.Length; i++)
            {
                char[] word = input[i].ToCharArray();
                int lowerCount = 0;
                int upperCount = 0;
                foreach (var ch in word)
                {
                    
                    if (ch >= 65 && ch <= 90)
                    {
                        upperCount++;
                    }
                    else if (ch >= 97 && ch <= 122)
                    {
                        lowerCount++;
                    }
                }

                if (upperCount == word.Length)
                {
                    upperCaseWords.Add(input[i]);
                }
                else if (lowerCount == word.Length)
                {
                    lowerCaseWords.Add(input[i]);
                }
                else 
                {
                    mixedCaseWords.Add(input[i]);
                }

                //bool isLower = word.ToCharArray().All(ch => char.IsLower(ch));
                //bool isUpper = word.ToCharArray().All(ch => char.IsUpper(ch));
                //if (isLower)
                //{
                //    lowerCaseWords.Add(word);
                //}
                //else if (isUpper)
                //{
                //    upperCaseWords.Add(word);
                //}
                //else
                //{
                //    mixedCaseWords.Add(word);
                //}

            }

            Console.WriteLine("Lower-case: " + string.Join(", ",lowerCaseWords));
            Console.WriteLine("Mixed-case: " + string.Join(", ",mixedCaseWords));
            Console.WriteLine("Upper-case: " + string.Join(", ",upperCaseWords));
        }
    }
}
