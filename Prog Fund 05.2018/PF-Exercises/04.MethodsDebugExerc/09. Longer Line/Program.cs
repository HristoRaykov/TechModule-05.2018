using System;

namespace _09._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] firstPointsCordinates = new double[4];
            double[] secondPointsCordinates = new double[4];
            for (int i = 0; i < 4; i++)
            {
                firstPointsCordinates[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                secondPointsCordinates[i] = double.Parse(Console.ReadLine());
            }

            double distance1 = GetDistanceBetweenPoints(firstPointsCordinates);
            double distance2 = GetDistanceBetweenPoints(secondPointsCordinates);

            if (distance1 >= distance2)
            {
                PrintClosestToTheCenterPoint(firstPointsCordinates);
            }
            else
            {
                PrintClosestToTheCenterPoint(secondPointsCordinates);
            }
        }

        private static void PrintClosestToTheCenterPoint(double[] cordinates)
        {
            double dist1 = Math.Sqrt(cordinates[0] * cordinates[0] + cordinates[1] * cordinates[1]);
            double dist2 = Math.Sqrt(cordinates[2] * cordinates[2] + cordinates[3] * cordinates[3]);
            if (dist1 <= dist2)
            {
                Console.WriteLine($"({cordinates[0]}, {cordinates[1]})({cordinates[2]}, {cordinates[3]})");
            }
            else
            {
                Console.WriteLine($"({cordinates[2]}, {cordinates[3]})({cordinates[0]}, {cordinates[1]})");
            }
        }

        private static double GetDistanceBetweenPoints(double[] cordinates)
        {
            double a = Math.Abs(cordinates[0] - cordinates[2]);
            double b = Math.Abs(cordinates[1] - cordinates[3]);
            double result = Math.Sqrt(a * a + b * b);
            return result;
        }
    }
}
