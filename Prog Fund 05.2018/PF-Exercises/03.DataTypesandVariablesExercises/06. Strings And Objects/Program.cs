using System;

namespace _06._Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Hello";
            string word2 = "World";
            object obj1 = word1 + " " + word2;
            string word3 = (string)obj1;
            Console.WriteLine(word3);
        }
    }
}
