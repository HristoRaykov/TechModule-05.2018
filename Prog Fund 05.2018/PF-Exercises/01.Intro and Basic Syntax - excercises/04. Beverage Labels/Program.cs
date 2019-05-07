using System;

namespace _04._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContentPer100Ml = int.Parse(Console.ReadLine());
            double sugarContentPer100Ml = double.Parse(Console.ReadLine());

            double totalEnergyContent = energyContentPer100Ml * volume/100.0;
            double totalSugarContent = sugarContentPer100Ml * volume/100.0;

            Console.WriteLine($"{volume}ml {name}:\n" +
                $"{totalEnergyContent}kcal, {totalSugarContent}g sugars");
        }
    }
}
