using System;
using System.Linq;

namespace _04._Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int a = 0;
            int b = 0;
            
            bool hasSuchNums = false;

            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    a = array[i];
                    b = array[j];
                    foreach (int c in array)
                    {
                        if (a+b == c)
                        {
                            hasSuchNums = true;
                            Console.WriteLine($"{a} + {b} == {c}");
                            break;
                        }
                    }
                }
            }

            if (!hasSuchNums)
            {
                Console.WriteLine("No");
            }

        }
    }
}
