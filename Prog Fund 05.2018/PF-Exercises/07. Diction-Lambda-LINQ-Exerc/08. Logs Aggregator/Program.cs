using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, int>> usersBook = 
                new SortedDictionary<string, SortedDictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string ip = input[0];
                string user = input[1];
                int duration = int.Parse(input[2]);
                
                if (!usersBook.ContainsKey(user))
                {
                    usersBook.Add(user, new SortedDictionary<string, int>());
                }
                SortedDictionary<string, int> ipsBook = usersBook[user];

                if (!ipsBook.ContainsKey(ip))
                {
                    ipsBook.Add(ip,0);
                }
                ipsBook[ip] += duration; 
            }


            

            foreach (var user in usersBook)
            {
                SortedDictionary<string, int> ipsBook = user.Value;
                int totalDuration = ipsBook.Values.Sum();
                Console.WriteLine($"{user.Key}: {totalDuration} [{string.Join(", ",ipsBook.Keys)}]");
            }

            Console.WriteLine();
        }
    }
}
