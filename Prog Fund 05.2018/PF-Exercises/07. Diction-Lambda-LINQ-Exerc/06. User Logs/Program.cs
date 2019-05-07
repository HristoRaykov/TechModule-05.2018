using System;
using System.Collections.Generic;

namespace _06._User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> userbook = new SortedDictionary<string, Dictionary<string, int>>();
            string[] delimiters = { "IP=", "message=", "user=" };
            while (true)
            {                
                string[] input = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                if (input[0].Equals("end"))
                {
                    break;
                }
                string ip = input[0].Trim();
                string user = input[2].Trim();

                if (!userbook.ContainsKey(user))
                {
                    userbook.Add(user, new Dictionary<string, int>());
                }
                Dictionary<string, int> ipBook = userbook[user];
                if (!ipBook.ContainsKey(ip))
                {
                    ipBook.Add(ip, 1);
                }
                else
                {
                    ipBook[ip]++;
                }

            }

            foreach (var userPair in userbook)
            {
                Console.WriteLine($"{userPair.Key}: ");
                Dictionary<string,int> ipBook = userPair.Value;
                int counter = 0;
                
                foreach (var ipPair in ipBook)
                {
                    counter++;
                    if (counter == ipBook.Count)
                    {
                        Console.Write($"{ipPair.Key} => {ipPair.Value}.");
                    }
                    else
                    {
                        Console.Write($"{ipPair.Key} => {ipPair.Value}, ");
                    }
                }
                Console.WriteLine();
            }


            Console.WriteLine();
        }
    }
}
