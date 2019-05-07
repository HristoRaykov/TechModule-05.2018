using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split().Select(double.Parse).ToList();

            list.Sort();

            Console.WriteLine(string.Join(" <= ",list));
        }
    }
}
