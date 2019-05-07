using System;

namespace _03.ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            decimal number;
            decimal sum = 0;

            for (int i = 0; i < numberCount; i++)
            {
                number = decimal.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
