using System;

namespace _10._Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string property = Console.ReadLine();

            switch (property)
            {
                case "face":
                    Console.WriteLine($"{GetFaceDiagonal(side):f2}");
                    break;
                case "space":
                    Console.WriteLine($"{GetSpaceDiagonal(side):f2}");
                    break;
                case "volume":
                    Console.WriteLine($"{GetVolume(side):f2}");
                    break;
                case "area":
                    Console.WriteLine($"{GetArea(side):f2}");
                    break;


            }

        }

        static double GetFaceDiagonal(double side)
        {
            return Math.Sqrt(2 * side * side);
        }

        static double GetSpaceDiagonal(double side)
        {
            return Math.Sqrt(3 * side * side);
        }

        static double GetVolume(double side)
        {
            return Math.Pow(side, 3);
        }

        static double GetArea(double side)
        {
            return 6 * side * side;
        }
    }
}
