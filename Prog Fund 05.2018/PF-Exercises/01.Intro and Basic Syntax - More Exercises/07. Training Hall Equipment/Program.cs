using System;

namespace _07._Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());
            string itemName;
            double itemPrice;
            int itemCount;
            double subTotal = 0;

            for (int i = 0; i < numberOfItems; i++)
            {
                itemName = Console.ReadLine();
                itemPrice = double.Parse(Console.ReadLine());
                itemCount = int.Parse(Console.ReadLine());

                if (itemCount>1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
                subTotal += itemPrice*itemCount;
            }

            double moneyLeft = budget - subTotal;
            Console.WriteLine($"Subtotal: ${subTotal:f2}");
            if (moneyLeft>=0)
            {
                Console.WriteLine($"Money left: ${moneyLeft:f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${Math.Abs(moneyLeft):f2} more.");
            }

            Console.ReadLine();
        }
    }
}
