using System;

namespace _03._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            PrintTriabgle(input);
            
        }
      

        static void PrintTriabgle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrintLine(i);
                Console.WriteLine();
            }
            for (int i = number - 1; i >= 1; i--)
            {
                PrintLine(i);
                Console.WriteLine();
            }
        }

        static void PrintLine(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
