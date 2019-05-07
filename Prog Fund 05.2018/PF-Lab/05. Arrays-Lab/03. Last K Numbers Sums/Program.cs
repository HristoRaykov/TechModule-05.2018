using System;

namespace _03._Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] array = new long[n];
            array[0] = 1;
            long sum = 0;
            for (int i = 0; i < n-1; i++)
            {
                checked
                {

                sum += array[i];
                if (i+1<=k)
                {
                    array[i+1] = sum;
                }
                else
                {
                    sum -= array[i - k];
                    array[i+1] = sum;
                }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");                
            }
            Console.WriteLine();
        }
    }
}
