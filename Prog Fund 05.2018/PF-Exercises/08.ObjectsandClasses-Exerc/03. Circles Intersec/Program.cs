using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersec
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] token1 = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] token2 = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Circle c1 = new Circle(new Point(token1[0],token1[1]),token1[2]);
            Circle c2 = new Circle(new Point(token2[0],token2[1]),token2[2]);

            bool hasIntersect = Circle.Intersect(c1,c2);
            if (hasIntersect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

    class Circle
    {
        Point Center { get; }
        double Radius { get; }

        public Circle(Point center,double radius)
        {
            this.Center = center;
            this.Radius = radius;
        }

        public static bool Intersect(Circle c1,Circle c2 )
        {
            double distance = Point.CalculateDistanceBetweenPoints(c1.Center,c2.Center);
            if (distance<= c1.Radius+c2.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Point
    {
        double X { get; }
        double Y { get; }

        public Point(double x,double y)
        {
            this.X = x;
            this.Y = y;
        }

        public static double CalculateDistanceBetweenPoints(Point a,Point b)
        {
            double result = Math.Sqrt(Math.Pow(Math.Abs(a.X - b.X),2) + Math.Pow(Math.Abs(a.Y - b.Y),2));
            return result;
        }
    }
}
