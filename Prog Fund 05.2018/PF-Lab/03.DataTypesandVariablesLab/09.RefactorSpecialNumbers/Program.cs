using System;

namespace _09.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            
            

            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;
                int number = num;

                while (number > 0)
                {
                    sumOfDigits += number % 10;
                    number = number / 10;
                }

                bool isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{num} -> {isSpecial}");
                
            }

        }
    }
}
