using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            List<int> array = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char[] chArr = input[i].ToCharArray();
                Array.Reverse(chArr);
                array.Add(int.Parse(new string(chArr)));
            }

            
            
            Console.WriteLine(array.Sum());
        }
    }
}
