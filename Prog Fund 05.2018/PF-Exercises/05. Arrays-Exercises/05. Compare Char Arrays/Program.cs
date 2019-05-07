using System;

namespace _05._Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Trim().Split(' ');
            string[] input2 = Console.ReadLine().Trim().Split(' ');

            char[] longerArray;
            char[] shorterArray;

            if (input1.Length >= input2.Length)
            {
                longerArray = new char[input1.Length];
                shorterArray = new char[input2.Length];

                for (int i = 0; i < input1.Length; i++)
                {
                    longerArray[i] = char.Parse(input1[i]);                    
                }
                for (int i = 0; i < input2.Length; i++)
                {                    
                    shorterArray[i] = char.Parse(input2[i]);
                }
            }
            else
            {
                longerArray = new char[input2.Length];
                shorterArray = new char[input1.Length];

                for (int i = 0; i < input2.Length; i++)
                {
                    longerArray[i] = char.Parse(input2[i]);
                }
                for (int i = 0; i < input1.Length; i++)
                {
                    shorterArray[i] = char.Parse(input1[i]);
                }
            }

            bool areEquals = true;
            for (int i = 0; i < shorterArray.Length; i++)
            {
                if (shorterArray[i].CompareTo(longerArray[i])<0)
                {
                    PrintArray(shorterArray);
                    PrintArray(longerArray);
                    areEquals = false;
                    break;
                }
                else if (shorterArray[i].CompareTo(longerArray[i]) > 0)
                {
                    PrintArray(longerArray);
                    PrintArray(shorterArray);
                    areEquals = false;
                    break;
                }
                
            }

            if (areEquals)
            {
                PrintArray(shorterArray);
                PrintArray(longerArray);
            }
            Console.WriteLine();
        }

        private static void PrintArray(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
    }
}
