using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> squareNums = new List<int>();

            foreach (var num in list)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squareNums.Add(num);
                }
            }

            squareNums.Sort((a,b) => b.CompareTo(a));
            //squareNums.Reverse();
            Console.WriteLine(string.Join(" ",squareNums));
        }
    }
}
