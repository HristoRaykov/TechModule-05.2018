using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Regex.Split(Console.ReadLine(), @"[^\w]").ToList();
            words.RemoveAll(str=>str.Equals(""));
            List<string> palindromes = new List<string>();

            foreach (var word in words)
            {
                if (isPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }
            palindromes= palindromes.Distinct().ToList();
            palindromes.Sort();
            Console.WriteLine(string.Join(", ",palindromes));
        }

        private static bool isPalindrome(string word)
        {            
            char[] chars = word.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);
            if (reversed==word)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
