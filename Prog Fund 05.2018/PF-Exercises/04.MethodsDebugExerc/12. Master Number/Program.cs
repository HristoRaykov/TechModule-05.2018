using System;


namespace _12._Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int number = 1; number <= n; number++)
            {
                if (isMasterNumber(number))
                {
                    Console.WriteLine(number);
                }
            }

        }


        static bool isMasterNumber(int number)
        {
            if (DoesSumOfDigitsDividesBy7(number) &&
                HasEvenDigit(number) &&
                isSymmetricNumber(number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool DoesSumOfDigitsDividesBy7(int number)
        {

            int sum = 0;
            int digit = 0;
            while (number > 0)
            {
                digit = number % 10;
                number /= 10;
                sum += digit;                
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool HasEvenDigit(int number)
        {
            string stringNum = number.ToString();
            for (int i = 0; i < stringNum.Length; i++)
            {
                int digit = int.Parse(stringNum[i].ToString());
                if (digit % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }
        static bool isSymmetricNumber(int number)
        {
            if (number == ReverseNumDigits(number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int ReverseNumDigits(int number)
        {
            int reversedNumber = 0;
            int digit = 0;
            while (number > 0)
            {
                digit = number % 10;
                number /= 10;
                reversedNumber *= 10;
                reversedNumber += digit;
            }
            return reversedNumber;
        }

    }
}
