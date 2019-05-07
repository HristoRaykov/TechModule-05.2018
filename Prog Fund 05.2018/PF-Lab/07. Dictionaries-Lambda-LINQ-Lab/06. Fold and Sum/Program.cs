using System;
using System.Linq;

namespace _06._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length / 4;
            int[] row1left = arr.Take(k).Reverse().ToArray();
            int[] row1right = arr.Reverse().Take(k).ToArray();
            int[] row1 = row1left.Concat(row1right).ToArray();
            int[] row2 = arr.Skip(k).Take(2 * k).ToArray();
            var sumArr = row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ", sumArr));



            //int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int k = input.Length/4;
            //int[] topArr = input.Take(k).Reverse().Concat(input.TakeLast(k).Reverse()).ToArray();
            //int[] botArr = input.Skip(k).Take(2 * k).ToArray();
            //int[] result = topArr.Select((num, index) => num + botArr[index]).ToArray();
            //Console.WriteLine(string.Join(" ",result));
        }
    }
}
