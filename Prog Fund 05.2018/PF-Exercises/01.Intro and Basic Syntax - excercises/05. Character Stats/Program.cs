using System;

namespace _05._Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            string healthBar = new string('|',currentHealth+1) + new string('.', maxHealth-currentHealth) + '|';
            string energyBar = new string('|', currentEnergy + 1) + new string('.', maxEnergy - currentEnergy) + '|';

            Console.WriteLine($"Name: {name}\n" +
                $"Health: {healthBar}\n" +
                $"Energy: {energyBar}");
            Console.ReadLine();
        }
    }
}
