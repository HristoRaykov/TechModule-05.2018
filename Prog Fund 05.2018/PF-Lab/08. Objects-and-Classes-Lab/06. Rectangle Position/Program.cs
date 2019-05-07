using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Rectangle inner = new Rectangle() { Left = input1[0], Top = input1[1], Width = input1[2], Height = input1[3]  };
            Rectangle outter = new Rectangle(input2[0], input2[1], input2[2], input2[3]);

            

            if (inner.isInside(outter))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }

            
        }


    }

    public class Rectangle
    {
        public int Left { get; set; } = 0;
        public int Top { get; set; } = 0;
        public int Width { get; set; } = 0;
        public int Height { get; set; } = 0;

        public int Right { get { return Left + Width; } }
        public int Bottom { get { return Top - Height; } }

        public Rectangle(int left, int top, int width, int height)
        {
            this.Left = left;
            this.Top = top;
            this.Width = width;
            this.Height = height;
        }

        public Rectangle()
        {

        }

        public bool isInside(Rectangle other)
        {
            bool result = (this.Left >= other.Left) && (this.Right <= other.Right) &&
                (this.Top<=other.Top) && (this.Bottom>=other.Bottom);
            return result;
        }


    }





}
