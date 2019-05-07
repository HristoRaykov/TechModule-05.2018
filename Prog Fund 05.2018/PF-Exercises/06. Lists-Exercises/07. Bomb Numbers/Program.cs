using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string[] input = Console.ReadLine().Split();
            int specialNum = int.Parse(input[0]);
            int specialNumPower = int.Parse(input[1]);

            while (array.IndexOf(specialNum) != -1)
            {
                Detonate(array,specialNum,specialNumPower);
            }

            Console.WriteLine(array.Sum());
        }

        private static void Detonate(List<int> array, int specialNum, int specialNumPower)
        {
            int index = array.IndexOf(specialNum);

            int startIndex = index - specialNumPower;
            int endIndex = index + specialNumPower;
            int count = endIndex - startIndex;
            
            if (startIndex<0)
            {
                startIndex = 0;
            }
            if(endIndex > array.Count -1)
            {
                endIndex = array.Count - 1;
            }

            count = endIndex - startIndex+1;
            array.RemoveRange(startIndex,count);
        }
    }
}
