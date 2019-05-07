using System;

namespace _02._Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string result = GetNumberSign(input);
            Console.WriteLine($"The number {input} is {result}.");
        }

        static string GetNumberSign(int number)
        {
            string result = "";

            if (number > 0)
            {
                result = "positive";
            }
            else if (number < 0)
            {
                result = "negative";
            }
            else
            {
                result = "zero";
            }

            return result;
        }
    }
}
