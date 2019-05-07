using System;

namespace _10._Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split(' ');
            int diff = int.Parse(Console.ReadLine());
            int[] array = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }

            int counter = 0;
            

            for (int index1 = 0; index1 < array.Length; index1++)
            {
                //for (int index2 = index1 + 1; index2 < array.Length; index2++)
                //{
                //    if (array[index1] - array[index2] == diff ||
                //        array[index2] - array[index1] == diff)
                //    {
                //        counter++;
                //    }
                //}
                int searchedNum1 = array[index1] - diff;
                int searchedNum2 = array[index1] + diff;
                if (Array.IndexOf(array, searchedNum1) != -1)
                {
                    counter++;
                }
                if (Array.IndexOf(array, searchedNum2) != -1)
                {
                    counter++;
                }

            }

            Console.WriteLine(counter);


        }

    }
}
