using System;

namespace _09._Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string word = "";

            for (int i = 0; i < n; i++)
            {
                word += Console.ReadLine();
            }
            Console.WriteLine("The word is: " + word);
        }
    }
}
