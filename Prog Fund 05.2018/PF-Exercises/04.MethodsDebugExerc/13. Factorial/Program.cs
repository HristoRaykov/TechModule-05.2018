using System;
using System.Numerics;

namespace _13._Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = CalcFactorial(n);
            Console.WriteLine(factorial);
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
