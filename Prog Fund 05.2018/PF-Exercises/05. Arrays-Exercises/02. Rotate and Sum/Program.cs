using System;

namespace _02._Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split(' ');
            int timesToRotate = int.Parse(Console.ReadLine());
            int[] array = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }

            int[] sum = new int[array.Length];
            for (int i = 0; i < timesToRotate; i++)
            {
                array = RotateRight(array);
                for (int index = 0; index < array.Length; index++)
                {
                    sum[index] += array[index];
                }
            }


            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(sum[i]);
                if (i!=array.Length-1)
                {
                    Console.Write(" ");
                }
            }

        }

        private static int[] RotateRight(int[] array)
        {
            int[] rotatedArray = new int[array.Length];
            
            Array.Copy(array,0,rotatedArray,1,array.Length-1);
            rotatedArray[0] = array[array.Length - 1];
            return rotatedArray;
        }
    }
}
