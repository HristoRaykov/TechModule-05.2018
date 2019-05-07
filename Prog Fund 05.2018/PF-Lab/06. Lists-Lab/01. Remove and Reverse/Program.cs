using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Remove_Negatives
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numsToDelete = new List<int>();


            list.RemoveAll(x => x < 0);
            list.Reverse();
            if (list.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}
