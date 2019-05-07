using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Sum__Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    list[i] += list[i + 1];
                    list.RemoveAt(i + 1);
                    if (i - 2 >= 0)
                    {
                        i -= 2;
                    }
                    else
                    {
                        i = -1;
                    }

                    while (i - 1 >= 0 && list[i] == list[i - 1])
                    {
                        i--;
                    }

                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
