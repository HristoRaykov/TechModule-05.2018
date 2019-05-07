using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                points[i] = new Point(input[0], input[1]);
                
            }

            Point[] closestPoints = Point.GetClosestPoints(points);
            double dist = Point.CalculateDistance(closestPoints[0],closestPoints[1]);

            Console.WriteLine($"{dist:f3}");
            Console.WriteLine($"({closestPoints[0].X}, {closestPoints[0].Y})");
            Console.WriteLine($"({closestPoints[1].X}, {closestPoints[1].Y})");
        }
    }

    class Point
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public Point()
        {

        }

        public static double CalculateDistance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(a.X - b.X), 2) + Math.Pow(Math.Abs(a.Y - b.Y), 2));
        }

        public static Point[] GetClosestPoints(Point[] points)
        {
            Point[] closestPoints = new Point[2];
            double minDistance = double.MaxValue;

            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = CalculateDistance(points[i], points[j]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestPoints[0] = points[i];
                        closestPoints[1] = points[j];
                    }
                }
            }

            return closestPoints;
        }

    }
}
