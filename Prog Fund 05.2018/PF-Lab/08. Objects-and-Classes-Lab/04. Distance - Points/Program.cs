using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance___Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] token1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] token2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point pointA = new Point(token1[0],token1[1]);
            Point pointB = new Point(token2[0],token2[1]);
            double dist = Point.CalculateDistance(pointA,pointB);
            Console.WriteLine(dist);
        }


    }

    public class Point
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static double CalculateDistance(Point a,Point b)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(a.X - b.X), 2) + Math.Pow(Math.Abs(a.Y - b.Y), 2));
        }

    }
}
