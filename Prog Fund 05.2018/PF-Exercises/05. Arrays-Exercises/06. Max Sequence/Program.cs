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
            int repeatingElement = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                int currentElement = array[i];
                int counter = 1;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] == currentElement)
                    {
                        i++;
                        counter++;
                        if (counter>maxCount)
                        {
                            repeatingElement = currentElement;
                            maxCount = counter;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }


            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(repeatingElement + " ");
            }
        }
    }
}
