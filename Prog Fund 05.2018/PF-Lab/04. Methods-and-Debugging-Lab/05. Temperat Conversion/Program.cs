using System;

namespace _05._Temperat_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp = double.Parse(Console.ReadLine());
            double result = FahrenheitToCelsius(temp);
            Console.WriteLine($"{result:f2}");
        }

        static double FahrenheitToCelsius(double tempInFahr)
        {
            double tempInCel = (tempInFahr - 32) * 5.0 / 9;
            return tempInCel;
        }
    }
}
