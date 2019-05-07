using System;

namespace _09._Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = Console.ReadLine().Trim().ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} -> {(int)array[i]-97}");
            }
            Console.WriteLine();
        }
    }
}
