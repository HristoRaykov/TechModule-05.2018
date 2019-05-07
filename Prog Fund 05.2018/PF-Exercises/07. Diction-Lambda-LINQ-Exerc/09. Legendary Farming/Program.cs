using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> legendaryMaterials = new Dictionary<string, double>(3);
            legendaryMaterials.Add("shards", 0);
            legendaryMaterials.Add("fragments", 0);
            legendaryMaterials.Add("motes", 0);
            SortedDictionary<string, double> junkMaterials = new SortedDictionary<string, double>();
            string legendaryObtained = "";

            while (true)
            {
                string[] input = Console.ReadLine().ToLower().Split();                

                for (int i = 0; i < input.Length; i += 2)
                {
                    double quantity = double.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (material.Equals("shards") || material.Equals("fragments") || material.Equals("motes"))
                    {
                        legendaryMaterials[material] += quantity;
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, 0);
                        }
                        junkMaterials[material] += quantity;
                    }

                    if (legendaryMaterials["shards"] >= 250)
                    {
                        legendaryObtained = "Shadowmourne";
                        legendaryMaterials["shards"] -= 250; 
                        break;
                    }
                    else if (legendaryMaterials["fragments"] >= 250)
                    {
                        legendaryMaterials["fragments"] -= 250;
                        legendaryObtained = "Valanyr";
                        break;
                    }
                    else if (legendaryMaterials["motes"] >= 250)
                    {
                        legendaryMaterials["motes"] -= 250;
                        legendaryObtained = "Dragonwrath";
                        break;
                    }   
                }
                if (legendaryObtained == "Shadowmourne" || legendaryObtained == "Valanyr" || legendaryObtained == "Dragonwrath")
                {
                    break;
                }
            }

            legendaryMaterials = legendaryMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key).
                ToDictionary(t => t.Key, t => t.Value);

            Console.WriteLine($"{legendaryObtained} obtained!");
            foreach (var material in legendaryMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
            foreach (var material in junkMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
            Console.WriteLine();
        }
    }
}
