using System;

namespace _04._NumInReverOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            ReverseDigitsOrder(number);

        }

        private static void ReverseDigitsOrder(string num)
        {
            for (int i = num.Length -1; i >= 0; i--)
            {
                Console.Write(num[i]);
            }
        }
    }
}
