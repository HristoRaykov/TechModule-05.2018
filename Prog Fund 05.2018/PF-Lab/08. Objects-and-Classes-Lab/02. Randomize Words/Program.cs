using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                string temp = words[i];
                int randomIndex = rnd.Next(0,words.Length);
                words[i] = words[randomIndex];
                words[randomIndex] = temp;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }


        }
    }
}
