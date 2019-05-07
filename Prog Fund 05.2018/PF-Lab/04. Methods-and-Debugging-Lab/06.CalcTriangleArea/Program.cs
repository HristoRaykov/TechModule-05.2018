using System;

namespace _06.CalcTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = CalcTriangleArea(side, height);
            Console.WriteLine(area);
        }

        private static double CalcTriangleArea(double side, double height)
        {
            return side * height / 2;
        }
    }
}
