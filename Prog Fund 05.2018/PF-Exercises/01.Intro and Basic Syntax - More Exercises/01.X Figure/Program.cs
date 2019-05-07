using System;

namespace _01.X_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string row;

            for (int i = 0; i < n/2; i++)
            {
                row = new string(' ', i)+'x' + new string(' ', n - 2-2*i) + 'x'+ new string(' ', i);
                Console.WriteLine(row);
            }
            Console.WriteLine(new string(' ',(n-1)/2)+'x'+ new string(' ', (n - 1) / 2));
            for (int i = 0; i < n / 2; i++)
            {
                row = new string(' ', (n-3-2*i)/2) + 'x' + new string(' ', 1+ 2 * i) + 'x' + new string(' ', (n - 3 - 2 * i) / 2);
                Console.WriteLine(row);
            }

            Console.ReadLine();
        }
    }
}
