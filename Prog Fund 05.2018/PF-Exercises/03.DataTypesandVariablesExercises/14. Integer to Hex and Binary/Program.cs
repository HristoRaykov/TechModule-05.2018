using System;

namespace _14._Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNum = int.Parse(Console.ReadLine());

            string hexNum = Convert.ToString(decimalNum, 16).ToUpper();
            string binaryNum = Convert.ToString(decimalNum, 2);

            Console.WriteLine(hexNum);
            Console.WriteLine(binaryNum);
        }
    }
}
