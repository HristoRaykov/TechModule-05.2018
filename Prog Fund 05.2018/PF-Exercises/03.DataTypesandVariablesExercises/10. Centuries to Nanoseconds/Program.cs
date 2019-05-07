using System;

namespace _10._Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            long seconds = minutes * 60L;
            decimal milisec = seconds * 1000;
            decimal microsec = milisec * 1000;
            decimal nanosec = microsec * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milisec} milliseconds = {microsec} microseconds = {nanosec} nanoseconds");
        }
    }
}
