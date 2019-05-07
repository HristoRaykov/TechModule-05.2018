using System;

namespace _04._Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFilledSquare(n);

        }

        private static void PrintFilledSquare(int n)
        {
            PrintMarginalRow(n);
            
            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddleRow(n);
                Console.WriteLine();
                
            }
            PrintMarginalRow(n);
        }

        private static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 2; i <= 2*n-1; i++)
            {
                if (i%2==0)
                {
                    Console.Write('\\');
                }
                else
                {
                    Console.Write('/');
                }

            }
            Console.Write('-');
        }

        static void PrintMarginalRow(int n)
        {
            Console.WriteLine(new string('-',2*n));
            
        }


    }
}
