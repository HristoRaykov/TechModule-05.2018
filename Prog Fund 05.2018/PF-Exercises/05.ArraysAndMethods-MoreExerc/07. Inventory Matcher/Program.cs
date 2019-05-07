using System;

namespace _07._Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Trim().Split(' ');
            string[] line2 = Console.ReadLine().Trim().Split(' ');
            string[] line3 = Console.ReadLine().Trim().Split(' ');

            long[] quantities = new long[line2.Length];
            decimal[] prices = new decimal[line3.Length];

            for (int i = 0; i < line2.Length; i++)
            {
                quantities[i] = long.Parse(line2[i]);
                prices[i] = decimal.Parse(line3[i]);
            }

            string input = Console.ReadLine();

            while (input != "done")
            {
                int index = Array.IndexOf(products,input);
                Console.WriteLine($"{products[index]} costs: {prices[index]}; Available quantity: {quantities[index]}");

                input = Console.ReadLine();
            }
        }
    }
}
