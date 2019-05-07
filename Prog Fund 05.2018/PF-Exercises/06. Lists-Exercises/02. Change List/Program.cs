using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();

            string[] input = Console.ReadLine().Split();
            bool isLastWordOdd = true;

            while (true)
            {
                if (input[0].Equals("Delete"))
                {
                    array.RemoveAll(x => x == int.Parse(input[1]));
                }
                else if (input[0].Equals("Insert"))
                {
                    array.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }
                else if (input[0].Equals("Odd"))
                {
                    break;
                }
                else if (input[0].Equals("Even"))
                {
                    isLastWordOdd = false;
                    break;
                }

                input = Console.ReadLine().Split();
            }

            if (isLastWordOdd)
            {
                Console.WriteLine(string.Join(" ", array.Where(x => x % 2 == 1)));
            }
            else
            {
                Console.WriteLine(string.Join(' ', array.Where(x => x % 2 == 0)));
            }
        }
    }
}
