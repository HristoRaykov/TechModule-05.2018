using System;

namespace _06._Max_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split(' ');
            int[] array = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }

            int maxCount = 1;
            int maxStartIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int startIndex = i;
                int counter = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[j-1])
                    {
                        i++;
                        counter++;
                        if (counter > maxCount)
                        {
                            maxStartIndex = startIndex;
                            maxCount = counter;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }


            for (int i = maxStartIndex; i < maxStartIndex+maxCount; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
