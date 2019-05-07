using System;

namespace _06._Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            const char jewel = '%';
            const char gold = '$';

            string[] prices = Console.ReadLine().Trim().Split(' ');
            int priceOfJewels = int.Parse(prices[0]);
            int priceOfGold = int.Parse(prices[1]);

            int totalEarnings = 0;
            int totalExpenses = 0;

            string input = Console.ReadLine();

            while (!input.Equals("Jail Time"))
            {
                string[] heist = input.Trim().Split(' ');
                string loot = heist[0];
                int expenses = int.Parse(heist[1]);

                totalExpenses += expenses;
                int jewelCount = GetCountOf(loot,jewel);
                int goldCount = GetCountOf(loot,gold);
                totalEarnings += (jewelCount * priceOfJewels + goldCount * priceOfGold);

                input = Console.ReadLine();
            }

            int result = totalEarnings - totalExpenses;
            if (result>=0)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {result}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(result)}.");
            }
        }

        private static int GetCountOf(string str, char ch)
        {
            int counter = 0;
            int startIndex = 0;
            int index = 0;
            while (true)
            {
                index = str.IndexOf(ch, startIndex);
                if (index == -1)
                {
                    break;
                }
                else
                {
                    startIndex = index + 1;
                    counter++;
                }
                              
                if (startIndex>=str.Length)
                {
                    break;
                }
            }
            return counter;
        }
    }
}
