using System;

namespace _07._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            
            double result = GetPower(num, power);
            Console.WriteLine(result);
            
        }

        static double GetPower(double num, int power)
        {
            double result = 1.0;
            for (int i = 0; i < power; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
