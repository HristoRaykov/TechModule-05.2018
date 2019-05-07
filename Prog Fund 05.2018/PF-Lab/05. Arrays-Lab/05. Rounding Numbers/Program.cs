using System;
using System.Linq;

namespace _05._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (double num in array)
            {
                Console.WriteLine($"{num} => {Math.Round(num,MidpointRounding.AwayFromZero)}");
            }

        }
    }
}
