using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|");
            List<int> result = new List<int>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                string[] innerArray = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < innerArray.Length; j++)
                {
                    result.Add(int.Parse(innerArray[j]));
                }
            }
            Console.WriteLine(string.Join(" ", result));

            // other solution
        //    List<List<int>> list = new List<List<int>>();
        //    list = Console.ReadLine()
        //        .Split("|")
        //        .ToList()
        //        .Select(item =>
        //            item.Split(" ", StringSplitOptions.RemoveEmptyEntries)
        //            .Select(int.Parse)
        //            .ToList()
        //            )
        //        .ToList();

        //    list.Reverse();

        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.Write(string.Join(" ", list[i]) + " ");
        //    }
        }
    }
}
