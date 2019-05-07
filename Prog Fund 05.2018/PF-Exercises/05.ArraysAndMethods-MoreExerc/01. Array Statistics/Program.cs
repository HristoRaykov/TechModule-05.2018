using System;

namespace _01._Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] inputArr = input.Trim().Split(' ');
            int[] arr = new int[inputArr.Length];
            for (int i = 0; i < inputArr.Length; i++)
            {
                arr[i] = int.Parse(inputArr[i]);
            }

            int minNum = int.MaxValue;
            int maxNum = int.MinValue;
            long sum = 0;
            

            foreach (var num in arr)
            {
                sum += num;
                if (num > maxNum)
                {
                    maxNum = num;
                }
                if (num < minNum)
                {
                    minNum = num;
                }
            }

            double average = (double)sum / arr.Length;

            Console.WriteLine($"Min = {minNum}\n" +
                $"Max = {maxNum}\n" +
                $"Sum = {sum}\n" +
                $"Average = {average}");

        }
    }
}
