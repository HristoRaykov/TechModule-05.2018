using System;
using System.Collections.Generic;

namespace _01._Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split();

            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (commands[0] != "END")
            {
                if (commands[0] == "A")
                {
                    string name = commands[1];
                    string number = commands[2];
                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, number);
                    }
                    else
                    {
                        phonebook[name] = number;
                    }

                }
                else if (commands[0] == "S")
                {
                    string name = commands[1];
                    if (!phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }

                }
                else if (commands[0] == "ListAll")
                {
                    foreach (var pair in phonebook)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }
                }

                commands = Console.ReadLine().Split();
            }


        }
    }
}
