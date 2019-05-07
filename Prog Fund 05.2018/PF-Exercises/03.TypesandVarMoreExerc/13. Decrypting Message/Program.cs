using System;
using System.Text;

namespace _13._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            char decryptedChar;

            StringBuilder message = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());
                decryptedChar = Convert.ToChar(input + key);
                message.Append(decryptedChar);

            }
            Console.WriteLine(message);

        }
    }
}
