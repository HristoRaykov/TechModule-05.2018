using System;

namespace _11._String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string row = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string output = "";

            if (row.Equals("odd"))
            {
                for (int i = 1; i <= n; i++)
                {
                    string input = Console.ReadLine();
                    if (i%2==1)
                    {
                        output += input + delimiter;
                    }
                }
            }

            if (row.Equals("even"))
            {
                for (int i = 1; i <= n; i++)
                {
                    string input = Console.ReadLine();
                    if (i % 2 == 0)
                    {
                        output += input + delimiter;
                    }
                }
            }

            output = output.Remove(output.Length-1);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
