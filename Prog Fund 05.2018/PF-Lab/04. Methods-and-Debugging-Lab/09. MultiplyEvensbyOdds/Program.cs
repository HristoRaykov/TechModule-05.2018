using System;

namespace _09._MultiplyEvensbyOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            int sumOfEvenDigits = CalcSumOfEvenDigits(number);
            int sumOfOddDigits = CalcSumOfOddDigits(number);

            Console.WriteLine(sumOfEvenDigits*sumOfOddDigits);
            
        }

        private static int CalcSumOfOddDigits(int number)
        {
            number = Math.Abs(number);
            int sum = 0;
            int digit = 0;
            while (number != 0)
            {
                digit = number % 10;
                if (digit % 2 == 1)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }

        private static int CalcSumOfEvenDigits(int number)
        {
            number = Math.Abs(number);
            int sum = 0;
            int digit = 0;
            while (number != 0)
            {
                digit = number % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
