using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substr_Occur
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string substr = Console.ReadLine().ToLower();

            int counter = 0;
            counter = GetSubstringOccurrence(text,substr);
            Console.WriteLine(counter);
        }

        private static int GetSubstringOccurrence(string text, string substr)
        {
            int counter = 0;
            int index = text.IndexOf(substr);

            while (true)
            {
                if (index==-1)
                {
                    break;
                }
                counter++;
                index = text.IndexOf(substr, index + 1);               
            }
            return counter;
        }
    }
}
