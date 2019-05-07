using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Max_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();

            int maxIndex = 0;
            int maxCounter = 1;

            for (int i = 0; i < array.Count; i++)
            {
                int counter = 1;
                int currIndex = i;
                int currElement = array[i];

                for (int j = i+1; j < array.Count; j++)
                {
                    if (currElement == array[j])
                    {
                        counter++;

                    }
                    else
                    {
                        break;
                    }

                }

                if (counter>maxCounter)
                {
                    maxCounter = counter;
                    maxIndex = currIndex;
                }

                i += counter-1;

            }

            Console.WriteLine(string.Join(' ',array.Select(x => Convert.ToString(x)).ToArray(), maxIndex,maxCounter));
        }
    }
}
