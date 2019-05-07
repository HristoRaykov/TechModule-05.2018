using System;

namespace _05._Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int fibNum = Fib(n);
            Console.WriteLine(fibNum);
        }

        private static int Fib(int n)
        {
            int firstNum = 1;
            int secondNum = 1;
            int tempNum = 0;
            int currentIndex = 2;
            if (n == 0 || n ==1)
            {
                return 1;
            }
            else
            {
                while (currentIndex <= n)
                {
                    tempNum = secondNum;
                    secondNum = firstNum + tempNum;
                    firstNum = tempNum;
                    currentIndex++;
                }
                return secondNum;
            }

            
        }
    }
}
