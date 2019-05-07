using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            //solution 3 dictionary
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (var num in list)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict.Add(num,1);
                }
            }

            List<int> sortedKeys = dict.Keys.ToList();
            sortedKeys.Sort();

            foreach (var key in sortedKeys)
            {
                Console.WriteLine($"{key} -> {dict[key]}");
            }

            //Solution 2
            //list.Sort();
            //int counter = 1;            
            //for (int i = 0; i < list.Count-1; i++)
            //{               
            //    if (list[i]==list[i+1])
            //    {
            //        counter++;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{list[i]} -> {counter}");
            //        counter = 1;
            //    }                              
            //}
            //Console.WriteLine($"{list[list.Count-1]} -> {counter}");




            //Solution 1
            //int maxElement = list.Max();
            //int[] counts = new int[maxElement+1];
            //foreach (var num in list)
            //{
            //    counts[num]++;
            //}
            //for (int i = 0; i < counts.Length; i++)
            //{
            //    if (counts[i] != 0)
            //    {
            //        Console.WriteLine($"{i} -> {counts[i]}");
            //    }
            //}

        }
    }
}
