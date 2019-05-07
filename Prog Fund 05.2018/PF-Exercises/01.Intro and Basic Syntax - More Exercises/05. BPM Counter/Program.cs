using System;

namespace _05._BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int beatsPerMinute = int.Parse(Console.ReadLine());
            int numberOfBeats = int.Parse(Console.ReadLine());

            double bars = Math.Round(numberOfBeats/4.0, 1);
            int minutes = numberOfBeats / beatsPerMinute;
            int seconds = (int)(((numberOfBeats % beatsPerMinute) / (double)beatsPerMinute)*60);

            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");

            Console.ReadLine();
        }
    }
}
