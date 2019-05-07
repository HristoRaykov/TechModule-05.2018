using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[arr.Length];

            if (arr.Length == 1)
            {
                Console.WriteLine(arr[0]);
            }
            else
            {
                while (condensed.Length > 1)
                {
                    condensed = new int[arr.Length - 1];
                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        condensed[i] = arr[i] + arr[i + 1];
                    }
                    arr = condensed;
                    
                }
                Console.WriteLine(condensed[0]);
            }
            
            
        }
    }
}
