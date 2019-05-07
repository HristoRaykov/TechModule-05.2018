using System;
using System.Linq;




namespace _11._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            int index = 0;

            int totalSum = 0;
            foreach (int item in array)
            {
                totalSum += item;
            }
            bool hasSuchIndex = false;
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }
                rightSum = totalSum - leftSum - array[i];
                if (leftSum==rightSum)
                {
                    index = i;
                    hasSuchIndex = true;
                    break;
                }
            }

            if (hasSuchIndex)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
