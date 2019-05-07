using System;

namespace _06._Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(n));
        }

        private static bool IsPrime(long number)
        {
            bool isPrime = true;
            if (number == 0 || number == 1)
            {
                isPrime = false;
            }
            else if (number == 2 || number == 3)
            {
                isPrime = true;
            }
            else
            {
                for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
                {
                    if (number % divisor == 0)
                    {
                        isPrime = false;
                    }
                }
            }
            return isPrime;

        }
    }
}
