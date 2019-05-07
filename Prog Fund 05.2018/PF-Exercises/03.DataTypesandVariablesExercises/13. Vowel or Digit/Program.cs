using System;

namespace _13._Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if (input >= 48 && input <= 57)
            {
                Console.WriteLine("digit");
            }
            else if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
            
        }
    }
}
