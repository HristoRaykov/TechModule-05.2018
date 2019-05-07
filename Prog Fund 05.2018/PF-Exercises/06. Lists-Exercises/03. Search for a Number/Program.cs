using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();
            int[] input = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            array.RemoveRange(input[0],array.Count-input[0]);
            array.RemoveRange(0,input[1]);

            if (array.Contains(input[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
