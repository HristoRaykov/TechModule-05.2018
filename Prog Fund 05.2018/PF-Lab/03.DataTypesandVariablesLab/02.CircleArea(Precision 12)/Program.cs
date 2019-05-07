using System;

namespace _02.CircleArea_Precision_12_
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = double.Parse(Console.ReadLine());

            double area = Math.PI * R * R;

            Console.WriteLine($"{area:f12}");
            Console.ReadLine();
        }
    }
}
