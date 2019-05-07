using System;

namespace _04._Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int sizeInBytes = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string name = $"DSC_{photoNumber:d4}.jpg";
            string dateAndTime = $"{day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}";
            string size = null;
            if (sizeInBytes>=1000000)
            {
                
                size = $"{sizeInBytes / 1000000.0}MB";
            }
            else if (sizeInBytes>=1000)
            {
                size = $"{sizeInBytes/1000.0}KB";
            }
            else if (sizeInBytes<1000)
            {
                size = $"{sizeInBytes}B";
            }
            string resolution = $"{width}x{height}";
            string orientation;
            if (width > height)
            {
                orientation = "landscape";
            }
            else if (width<height)
            {
                orientation = "portrait";
            }
            else
            {
                orientation = "square";
            }

            Console.WriteLine($"Name: {name}\n" +
                $"Date Taken: {dateAndTime}\n" +
                $"Size: {size}\n" +
                $"Resolution: {resolution} ({orientation})");

            Console.ReadLine();
        }
    }
}
