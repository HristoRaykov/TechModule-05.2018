using System;

namespace _04._Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexadec = Console.ReadLine();

            int dec = Convert.ToInt32(hexadec, 16);
            Console.WriteLine(dec);
        }
    }
}
