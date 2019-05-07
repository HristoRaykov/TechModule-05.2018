using System;

namespace _02._ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int[] reversedArrays = new int[n];

            for (int i = 0; i < n; i++)
            {
                reversedArrays[i] = numbers[n - 1 - i];
                Console.Write(reversedArrays[i]);
                if (i!=n-1)
                {
                    Console.Write(" ");
                }
            }

        }
    }
}
