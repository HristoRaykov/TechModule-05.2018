using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, List<int>>> dragonTypeBook = new
                Dictionary<string, SortedDictionary<string, List<int>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string type = input[0];
                string name = input[1];
                int damage = 0;
                int health = 0;
                int armor = 0;
                if (input[2].Equals("null"))
                {
                    damage = 45;
                }
                else
                {
                    damage = int.Parse(input[2]);
                }
                if (input[3].Equals("null"))
                {
                    health = 250;
                }
                else
                {
                    health = int.Parse(input[3]);
                }
                if (input[4].Equals("null"))
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(input[4]);
                }
                List<int> stats = new List<int>(3) { damage, health, armor };

                if (!dragonTypeBook.ContainsKey(type))
                {
                    dragonTypeBook.Add(type, new SortedDictionary<string, List<int>>());
                }
                SortedDictionary<string, List<int>> dragonNameBook = dragonTypeBook[type];
                if (!dragonNameBook.ContainsKey(name))
                {
                    dragonNameBook.Add(name, new List<int>());
                }
                dragonNameBook[name] = stats;
                dragonTypeBook[type] = dragonNameBook;
            }

            Dictionary<string, List<double>> averageStatBook = new Dictionary<string, List<double>>();

            foreach (var type in dragonTypeBook.Keys)
            {
                SortedDictionary<string, List<int>> dragonNameBook = dragonTypeBook[type];
                if (!averageStatBook.ContainsKey(type))
                {
                    averageStatBook.Add(type, new List<double>(3) { 0, 0, 0 });
                }                
                averageStatBook[type][0] = dragonNameBook.Values.Average(list => list[0]);
                averageStatBook[type][1] = dragonNameBook.Values.Average(list => list[1]);
                averageStatBook[type][2] = dragonNameBook.Values.Average(list => list[2]);
            }


            foreach (var type in dragonTypeBook.Keys)
            {
                double avDamage = averageStatBook[type][0];
                double avHealth = averageStatBook[type][1];
                double avArmor = averageStatBook[type][2];
                Console.WriteLine($"{type}::({avDamage:f2}/{avHealth:f2}/{avArmor:f2})");
                SortedDictionary<string, List<int>> dragonNameBook = dragonTypeBook[type];
                foreach (var name in dragonNameBook.Keys)
                {
                    int damage = dragonNameBook[name][0];
                    int health = dragonNameBook[name][1];
                    int armor = dragonNameBook[name][2];
                    Console.WriteLine($"-{name} -> damage: {damage}, health: {health}, armor: {armor}");
                }
            }

            Console.WriteLine();
        }
    }
}
