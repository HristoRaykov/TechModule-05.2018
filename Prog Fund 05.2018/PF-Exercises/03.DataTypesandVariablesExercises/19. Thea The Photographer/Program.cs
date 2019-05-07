using System;

namespace _19._Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());
                      
            int filteredPics = (int)Math.Ceiling(1.0 * numberOfPictures * filterFactor / 100.0);
            double totalFilterTime = 1.0*numberOfPictures * filterTime;
            
            double totalUploadTime = 1.0 * filteredPics * uploadTime;
            double totaltime = (totalFilterTime + totalUploadTime);

            ulong days = (ulong)(totaltime / (24 * 60 * 60));
            ulong timeLeftInSec = (ulong)(totaltime % (24 * 60 * 60));
            int hours = (int)(timeLeftInSec / (60 * 60));
            timeLeftInSec %= (60 * 60);
            int minutes = (int)(timeLeftInSec / 60);
            int seconds = (int)(timeLeftInSec % 60);

            Console.WriteLine($"{days}:{hours:d2}:{minutes:d2}:{seconds:d2}");
            
        }
    }
}
