﻿using System;

namespace _01._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = 100 * centuries;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
            Console.ReadLine();

        }
    }
}
