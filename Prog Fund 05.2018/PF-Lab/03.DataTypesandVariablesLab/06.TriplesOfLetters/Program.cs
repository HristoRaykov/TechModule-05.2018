using System;

namespace _06.TriplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (char i1 = 'a'; i1 < 97+n; i1++)
            {
                for (char i2 = 'a'; i2 < 97 + n; i2++)
                {
                    for (char i3 = 'a'; i3 < 97 + n; i3++)
                    {
                        Console.WriteLine($"{i1}{i2}{i3}");
                    }
                }
            }
        }
    }
}
