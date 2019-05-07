using System;
using System.Collections.Generic;

namespace _04._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, string> register = new Dictionary<string, string>();

            while (input != "stop")
            {
                string name = input;
                string email = Console.ReadLine();

                if (!register.ContainsKey(name))
                {
                    register.Add(name, email);
                }
                else
                {
                    register[name] = email;
                }

                input = Console.ReadLine();
            }

            foreach (var pair in register)
            {
                if (pair.Value.ToLower().EndsWith(".us") || pair.Value.ToLower().EndsWith(".uk"))
                {
                    register.Remove(pair.Key);
                }
            }

            foreach (var pair in register)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }

        }
    }
}
