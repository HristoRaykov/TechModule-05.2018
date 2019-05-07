using System;

namespace _05._Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Contains("."))
            {
                Console.WriteLine("Rainy");
            }
            else
            {
                if (sbyte.TryParse(input, out sbyte sbuteNum))
                {
                    Console.WriteLine("Sunny");
                }
                else if (int.TryParse(input, out int intNum))
                {
                    Console.WriteLine("Cloudy");
                }
                else if (long.TryParse(input, out long longNum))
                {
                    Console.WriteLine("Windy");
                }
            }


        }
    }
}
