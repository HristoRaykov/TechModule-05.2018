using System;

namespace _07._Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"Before: \n" +
                $"a = {a}\n" +
                $"b = {b}");

            int x = a;
            a = b;
            b = x;
            Console.WriteLine($"After: \n" +
                $"a = {a}\n" +
                $"b = {b}");

        }
    }
}
