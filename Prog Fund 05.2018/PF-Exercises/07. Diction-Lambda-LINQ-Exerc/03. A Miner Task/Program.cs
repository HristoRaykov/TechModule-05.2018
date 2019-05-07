using System;
using System.Collections.Generic;

namespace _03._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            string input = Console.ReadLine();
            

            while (input != "stop")
            {
                string resource = input;
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, 0);
                }
                resources[resource] += quantity;
                
                input = Console.ReadLine();
            }

            foreach (var pair in resources)
            {
                Console.WriteLine($"{pair.Key} –> {pair.Value}");
            }
            
        }
    }
}
