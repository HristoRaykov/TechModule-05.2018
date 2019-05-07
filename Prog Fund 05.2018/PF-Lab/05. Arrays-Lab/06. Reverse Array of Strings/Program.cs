using System;

namespace _06._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int len = arr.Length - 1;
            for (int i = 0; i < arr.Length/2; i++)
            {
                string temp = arr[i];
                arr[i] = arr[len - i];
                arr[len - i] = temp;
            }

            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
