using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();

            foreach (double num in input)
            {
                if (numbers.ContainsKey(num) == false)
                {
                    numbers.Add(num,0);
                }
                numbers[num]++;
            }

            foreach (var pair in numbers)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
