using System;

namespace _08._Most_Frequent_Number
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

            bool[] isChecked = new bool[array.Length];
            isChecked[0] = true;
            int maxCount = 1;
            int searchedElement = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                int counter = 1;
                int currentElement = array[i];
                for (int j = i+1; j < array.Length; j++)
                {
                    if (isChecked[j] == false)
                    {
                        if (array[j] == currentElement)
                        {
                            isChecked[j] = true;
                            counter++;
                            if (counter > maxCount)
                            {
                                maxCount = counter;
                                searchedElement = currentElement;
                            }
                        }
                    }
                    
                }
            }

            Console.WriteLine(searchedElement);

        }
    }
}
