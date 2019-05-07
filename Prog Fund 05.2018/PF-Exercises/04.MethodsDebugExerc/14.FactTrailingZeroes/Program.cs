using System;
using System.Numerics;

namespace _14.FactTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = CalcFactorial(n);
            int numberOfZeros = GetNumberOfTrailingZeroes(factorial);
            Console.WriteLine(numberOfZeros);
        }

        private static int GetNumberOfTrailingZeroes(BigInteger factorial)
        {
            int counter = 0;
            while (factorial % 10 == 0)
            {
                counter++;
                factorial /= 10;
            }
            return counter;
        }

        private static BigInteger CalcFactorial(int n)
        {
            BigInteger factoriaL = 1;
            for (int num = 1; num <= n; num++)
            {
                factoriaL *= num;
            }
            return factoriaL;
        }

        
    }
}
