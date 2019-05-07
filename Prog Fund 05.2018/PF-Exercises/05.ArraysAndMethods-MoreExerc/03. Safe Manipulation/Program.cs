﻿using System;

namespace _03._Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            

            string[] array = input.Trim().Split(' ');
            string[] command = Console.ReadLine().Trim().Split(' ');

            while (!command[0].Equals("END"))
            {

                switch (command[0])
                {
                    case "Reverse":
                        array = Reverse(array);
                        break;
                    case "Distinct":
                        array = Distinct(array);
                        break;
                    case "Replace":
                        int index = int.Parse(command[1]);
                        if (index < 0 || index >=array.Length)
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        else
                        {
                            array[index] = command[2];
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
                command = Console.ReadLine().Trim().Split(' ');
            }

            PrintArray(array);



        }

        private static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.Write(array[i]);
                }
                else
                {
                    Console.Write(array[i] + ", ");
                }
            }
        }

        private static string[] Distinct(string[] array)
        {
            bool[] isUnique = new bool[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                isUnique[i] = true;
            }
            int nonUniqueElemCount = 0;
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    bool areEquals = array[i].Equals(array[j]);
                    if (areEquals)
                    {
                        isUnique[i] = false;
                        nonUniqueElemCount++;
                        break;
                    }
                }
            }

            string[] uniqueElemArr = new string[array.Length - nonUniqueElemCount];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (isUnique[i])
                {
                    uniqueElemArr[index] = array[i];
                    index++;
                }
            }

            return uniqueElemArr;
        }

        private static string[] Reverse(string[] array)
        {
            string[] reversedArr = new string[array.Length];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversedArr[array.Length - 1 - i] = array[i];
            }
            return reversedArr;
        }
    }
}
