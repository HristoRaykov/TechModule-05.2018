using System;

namespace _09._Jump_Around
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

            int index = 0;
            int step = array[0];
            int sum = array[0];
            if (index + step < array.Length)
            {
                index += step;
                step = array[index];
                sum += array[index];
                
            }
            

            while (true)
            {
                if (index + step < array.Length)
                {
                    index += step;
                    step = array[index];
                    sum += array[index];
                }
                else if (index - step >=0)
                {
                    index -= step;
                    step = array[index];
                    sum += array[index];
                }
                else
                {
                    break;
                }
                

            }

            Console.WriteLine(sum);
        }
    }
}
