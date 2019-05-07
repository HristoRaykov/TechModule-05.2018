using System;

namespace _08._Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Trim().Split(' ');
            string[] line2 = Console.ReadLine().Trim().Split(' ');
            string[] line3 = Console.ReadLine().Trim().Split(' ');

            long[] quantities = new long[products.Length];
            decimal[] prices = new decimal[products.Length];

            for (int i = 0; i < products.Length; i++)
            {
                try
                {
                    quantities[i] = long.Parse(line2[i]);
                }
                catch
                {
                    quantities[i] = 0L;
                }
                prices[i] = decimal.Parse(line3[i]);
            }

            string[] input = Console.ReadLine().Trim().Split(' ');

            long orderedQuantity = 0L;
            long productQuantity = 0L;
            decimal totalOrderPrice = 0L;
            string productName = "";
            decimal productPrice = 0M;

            while (input[0] != "done")
            {
                orderedQuantity = long.Parse(input[1]);
                int index = Array.IndexOf(products, input[0]);
                productName = products[index];
                productPrice = prices[index];
                productQuantity = quantities[index];
                totalOrderPrice = orderedQuantity * productPrice;

                if (orderedQuantity>productQuantity)
                {
                    Console.WriteLine($"We do not have enough {productName}");
                }
                else
                {
                    Console.WriteLine($"{productName} x {orderedQuantity} costs {totalOrderPrice:f2}");
                    quantities[index] -= orderedQuantity;
                }

                

                input = Console.ReadLine().Trim().Split(' ');
            }
        }
    }
}
