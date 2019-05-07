using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> venuesBook = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals("End"))
                {
                    break;
                }
                string singer = "";
                int ticketPrice = 0;
                int ticketsCount = 0;
                string venue = "";
                try
                {                    
                    string[] splittedInput = input.Split('@');
                    if (splittedInput.Length!=2)
                    {
                        continue;
                    }
                    string leftSide = splittedInput[0];
                    singer = leftSide;
                    string rightSide = splittedInput[1];
                    if (!singer.EndsWith(" "))
                    {
                        continue;
                    }
                    singer = singer.Trim();
                    string ticketPriceString = splittedInput[1].Trim().Split().SkipLast(1).TakeLast(1).ToArray()[0].ToString();
                    string ticketCountString = splittedInput[1].Trim().Split().TakeLast(1).ToArray()[0].ToString();
                    ticketPrice = int.Parse(ticketPriceString);
                    ticketsCount = int.Parse(ticketCountString);
                    venue = string.Join(" ",splittedInput[1].Split().SkipLast(2).ToArray());
                }
                catch
                {
                    continue;
                }                

                if (!venuesBook.ContainsKey(venue))
                {
                    venuesBook.Add(venue,new Dictionary<string, int>());
                }
                Dictionary<string, int> singersBook = venuesBook[venue];

                if (!singersBook.ContainsKey(singer))
                {
                    singersBook.Add(singer,0);
                }
                singersBook[singer] += ticketPrice * ticketsCount;
                venuesBook[venue] = singersBook;
            }

            foreach (var venue in venuesBook.Keys)
            {
                Console.WriteLine($"{venue}");
                Dictionary<string, int> singersBook = venuesBook[venue].OrderByDescending(singer => singer.Value)
                    .ToDictionary(t => t.Key, t => t.Value); ;
                foreach (var singer in singersBook)
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
                
            }


            Console.WriteLine();
        }

    }
}
