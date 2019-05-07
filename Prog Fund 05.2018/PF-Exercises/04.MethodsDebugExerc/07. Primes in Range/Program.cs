using System;
using System.Collections.Generic;

namespace _07._Primes_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            List<int> primesNumList = FindPrimesInRange(startNum, endNum);
            PrintList(primesNumList);
        }

        private static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primesInRange = new List<int>();

            for (int num = startNum; num <= endNum; num++)
            {
                bool isPrime = true;
                if (num <= 1)
                {
                    continue;
                }
                else if (num == 2 || num == 3)
                {
                    primesInRange.Add(num);
                }
                else
                {
                    for (int divisor = 2; divisor <= Math.Sqrt(num); divisor++)
                    {
                        if (num % divisor == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        primesInRange.Add(num);
                    }
                }
            }
            return primesInRange;
        }

        private static void PrintList(List<int> primesNumList)
        {
            for (int index = 0; index < primesNumList.Count; index++)
            {
                {
                    if (index == primesNumList.Count-1)
                    {
                        Console.WriteLine(primesNumList[index]);
                    }
                    else
                    {
                        Console.Write($"{primesNumList[index]}, ");
                    }                    
                }
            }
        }
    }
}
