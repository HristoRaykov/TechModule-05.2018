using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, List<string>> cardRegister = new Dictionary<string, List<string>>();

            while (input[0] != "JOKER")
            {
                string name = input[0];
                List<string> cards = input[1].Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!cardRegister.ContainsKey(name))
                {
                    cardRegister.Add(name, new List<string>());

                }

                cardRegister[name] = cardRegister[name].Concat(cards).Distinct().ToList();
               
                input = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
            }

            Dictionary<string, int> cardsSum = new Dictionary<string, int>();



            foreach (var pair in cardRegister)
            {

                if (!cardsSum.ContainsKey(pair.Key))
                {
                    cardsSum.Add(pair.Key, 0);
                }
                int sum = 0;

                foreach (var card in cardRegister[pair.Key])
                {
                    string strPower = new string(card.ToCharArray().SkipLast(1).ToArray());
                    int powerNum = GetPower(strPower);
                    char type = card.ToCharArray().TakeLast(1).ToArray()[0];
                    int typeNum = GetType(type);
                    sum += powerNum * typeNum;
                }
                cardsSum[pair.Key] = sum;

            }

            foreach (var pair in cardsSum)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

        }

        private static int GetPower(string str)
        {
            char v = ' ';
            int result = 0;
            if (str.Length > 1)
            {
                result = 10;
            }
            else
            {
                v = str.ToArray()[0];
                if (char.IsDigit(v))
                {
                    result = int.Parse(v.ToString());
                }
                else if (v.Equals('J'))
                {
                    result = 11;
                }
                else if (v.Equals('Q'))
                {
                    result = 12;
                }
                else if (v.Equals('K'))
                {
                    result = 13;
                }
                else if (v.Equals('A'))
                {
                    result = 14;
                }
            }

            return result;
        }

        private static int GetType(char v)
        {
            int result = 0;
            if (v.Equals('S'))
            {
                result = 4;
            }
            else if (v.Equals('H'))
            {
                result = 3;
            }
            else if (v.Equals('D'))
            {
                result = 2;
            }
            else if (v.Equals('C'))
            {
                result = 1;
            }
            return result;
        }
    }
}
