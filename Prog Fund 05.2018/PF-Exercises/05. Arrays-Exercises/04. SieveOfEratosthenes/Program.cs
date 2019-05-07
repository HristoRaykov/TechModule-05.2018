using System;

namespace _04._SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool[] isPrime = new bool[n+1];
            for (int i = 0; i < n+1; i++)
            {
                isPrime[i] = true;
            }
            
            isPrime[0] = isPrime[1] = false;

            int smallestPrime = 2;
            while (smallestPrime < n+1)
            {
                if (isPrime[smallestPrime] == true)
                {
                    Console.Write(smallestPrime+ " ");
                    for (int multiplier = 2; smallestPrime * multiplier < n+1; multiplier++)
                    {
                        isPrime[multiplier * smallestPrime] = false;
                    }
                    smallestPrime++;
                }
                else
                {
                    smallestPrime++;
                }
            }



        }      
    }
}
