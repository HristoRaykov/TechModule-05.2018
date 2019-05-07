using System;

namespace _11._Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int sec = int.Parse(Console.ReadLine());

            decimal speedMetersPerSec = distanceInMeters / (hours * 3600m + minutes * 60m + sec);
            decimal speedKmPerHours = (distanceInMeters / 1000m) / (hours + minutes / 60m + sec / 3600m);
            decimal speedMpPerHours = (distanceInMeters / 1609m) / (hours + minutes / 60m + sec / 3600m);

            Console.WriteLine($"{speedMetersPerSec:f6}");
            Console.WriteLine($"{speedKmPerHours:f6}");
            Console.WriteLine($"{speedMpPerHours:f6}");
            Console.ReadLine();
        }
    }
}
