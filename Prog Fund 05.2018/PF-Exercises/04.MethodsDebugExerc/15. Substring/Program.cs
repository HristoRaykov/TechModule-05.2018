using System;

namespace _15._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            const char charToFind = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (currentChar == charToFind)
                {
                    hasMatch = true;

                    int len = count+1;

                    if (i + count > text.Length -1)
                    {
                        len = (text.Length-1)-i +1;
                    }

                    string matchedString = text.Substring(i, len);
                    Console.WriteLine(matchedString);
                    i += count;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
