using System;

namespace _04._Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {           
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string[] inputArr = input.Trim().Split(' ');
            int[] array = new int[inputArr.Length];
            for (int i = 0; i < inputArr.Length; i++)
            {
                array[i] = int.Parse(inputArr[i]);
            }

            int index = Array.LastIndexOf(array, n);
            
            long sum = 0;
            for (int i = 0; i < index; i++)
            {
                sum += array[i];
            }

            if (index == -1)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                Console.WriteLine(sum);
            }
            
        }
    }
}
