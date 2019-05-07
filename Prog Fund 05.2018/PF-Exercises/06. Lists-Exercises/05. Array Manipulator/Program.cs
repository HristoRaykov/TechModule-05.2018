using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();

            string[] commands = Console.ReadLine().Trim().Split();


            while (true)
            {
                if (commands[0].Equals("add"))
                {
                    nums.Insert(int.Parse(commands[1]), int.Parse(commands[2]));
                }
                else if (commands[0].Equals("addMany"))
                {
                    List<int> elementsToAdd = new List<int>();
                    for (int i = 2; i < commands.Length; i++)
                    {
                        elementsToAdd.Add(int.Parse(commands[i]));
                    }
                    nums.InsertRange(int.Parse(commands[1]), elementsToAdd);
                }
                else if (commands[0].Equals("contains"))
                {
                    Console.WriteLine(nums.IndexOf(int.Parse(commands[1])));
                }
                else if (commands[0].Equals("remove"))
                {
                    nums.RemoveAt(int.Parse(commands[1]));
                }
                else if (commands[0].Equals("shift"))
                {
                    ShiftElementsLeft(nums, int.Parse(commands[1]));
                    
                }
                else if (commands[0].Equals("sumPairs"))
                {
                    nums = SumPairs(nums);
                }
                else
                if (commands[0].Equals("print"))
                {
                    break;
                }

                commands = Console.ReadLine().Trim().Split();
            }

            Print(nums);
            Console.WriteLine();

        }

        private static void Print(List<int> nums)
        {
            Console.Write("[");
            for (int i = 0; i < nums.Count; i++)
            {
                if (i == nums.Count - 1)
                {
                    Console.Write(nums[i]);
                }
                else
                {
                    Console.Write(nums[i] + ", ");
                }

            }
            Console.Write("]");
        }

        private static List<int> SumPairs(List<int> nums)
        {
            int sum = 0;

            List<int> sumArr = new List<int>();
            for (int i = 0; i < nums.Count; i+=2)
            {               
                if (i==nums.Count-1)
                {
                    sum = nums[i];
                }
                else
                {
                    sum = nums[i] + nums[i + 1];
                }               
                sumArr.Add(sum);               
            }
            return sumArr;
        }

        private static void ShiftElementsLeft(List<int> array, int step)
        {
            if (step > array.Count)
            {
                step =  step % array.Count;
            }
            //for (int i = 0; i < step; i++)
            //{
            //    ShiftOneStepLeft(array);
            //}
            //int[] shiftedArr = new int[array.Count];
            //int[] arrayCopy = array.ToArray();
            //Array.Copy(arrayCopy, step, shiftedArr, 0, array.Count - step);
            //Array.Copy(arrayCopy, 0, shiftedArr, step + 1, step);

            
            array.AddRange(array.GetRange(0, step));
            array.RemoveRange(0, step);

        }

        private static void ShiftOneStepLeft(List<int> array)
        {
            int temp = array[0];
            for (int i = 1; i < array.Count; i++)
            {
                array[i - 1] = array[i];
            }
            array[array.Count - 1] = temp;
            
        }
    }
}
