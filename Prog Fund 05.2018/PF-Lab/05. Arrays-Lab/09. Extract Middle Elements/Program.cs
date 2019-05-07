using System;
using System.Linq;

namespace _09._Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int len = arr.Length;
            int[] middleElements;
            int index = 0;

            if (len == 1)
            {
                middleElements = arr;
            }
            else if (len % 2 == 0)
            {
                middleElements = new int[2];
                index = len / 2 - 1;
                middleElements[0] = arr[index];
                middleElements[1] = arr[index + 1];
            }
            else
            {
                middleElements = new int[3];
                index = len / 2;
                middleElements[0] = arr[index - 1];
                middleElements[1] = arr[index];
                middleElements[2] = arr[index + 1];

            }

            Console.WriteLine("{ "+string.Join(", ",middleElements)+" }");


        }
    }
}
