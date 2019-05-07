using System;

namespace _03._Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double megaPixels = Math.Round(width * height / 1000000.0, 1);
            Console.WriteLine($"{width}x{height} => {megaPixels}MP");

            Console.ReadLine();
        }

        
    }
}
