using System;
using System.Linq;

namespace _07._Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] shorterArray;
            int[] longerArray;


            if (arr1.Length <= arr2.Length)
            {
                shorterArray = arr1;
                longerArray = arr2;
            }
            else
            {
                shorterArray = arr2;
                longerArray = arr1;
            }
            int len = longerArray.Length;
            int[] modifiedArray = new int[len];

            for (int i = 0; i < len; i++)
            {
                modifiedArray[i] = shorterArray[i % shorterArray.Length];
            }

            int[] sumArray = new int[len];

            for (int i = 0; i < len; i++)
            {
                sumArray[i] = modifiedArray[i] + longerArray[i];
            }

            Console.WriteLine(string.Join(" ",sumArray));
        }
    }
}
