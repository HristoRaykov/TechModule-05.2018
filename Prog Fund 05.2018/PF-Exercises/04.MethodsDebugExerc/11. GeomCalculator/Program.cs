using System;

namespace _11._GeomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            switch (figure)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{CalculateTriangleArea(side,height):f2}");
                    break;
                case "square":
                    double sideSquare = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{CalculateSquareArea(sideSquare):f2}");
                    break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double heightRec = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{CalculateRectangleArea(width, heightRec):f2}");
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{CalculateCircleArea(radius):f2}");
                    break;
            }



        }

        static double CalculateTriangleArea(double side, double height)
        {
            return side * height / 2;
        }

        static double CalculateSquareArea(double side)
        {
            return side * side;
        }

        static double CalculateRectangleArea(double width, double height)
        {
            return width * height;
        }

        static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius* radius;
        }
    }
}
