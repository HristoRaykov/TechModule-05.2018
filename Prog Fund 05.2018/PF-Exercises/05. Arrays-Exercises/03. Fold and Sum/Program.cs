using System;

namespace _03._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split(' ');

            int k = input.Length / 4;

            int[] leftArray = new int[k];
            int[] midArray = new int[2*k];
            int[] rightArray = new int[k];

            for (int i = 0; i < k; i++)
            {
                leftArray[i] = int.Parse(input[i]);
                rightArray[i] = int.Parse(input[i+3*k]);
            }
            for (int i = k; i < 3*k; i++) 
            {
                midArray[i-k] = int.Parse(input[i]);
            }

            Array.Reverse(leftArray);
            Array.Reverse(rightArray);
            int[] leftRightArray = new int[2 * k];
            Array.Copy(leftArray,leftRightArray,leftArray.Length);
            Array.Copy(rightArray,0,leftRightArray,k,k);

            for (int i = 0; i < 2*k; i++)
            {
                Console.Write(leftRightArray[i]+midArray[i]);
                Console.Write(' ');
            }
        }
    }
}
