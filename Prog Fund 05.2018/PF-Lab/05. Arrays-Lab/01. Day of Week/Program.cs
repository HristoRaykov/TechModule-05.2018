using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNum = int.Parse(Console.ReadLine());

            //string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };


            //if (dayNum <= 7 && dayNum >=1)
            //{
            //    Console.WriteLine(days[dayNum - 1]);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Day");
            //}

            DayOfWeek[] daysInEnglish = new DayOfWeek[7]
            {
                DayOfWeek.Monday,
                DayOfWeek.Tuesday,
                DayOfWeek.Wednesday,
                DayOfWeek.Thursday,
                DayOfWeek.Friday,
                DayOfWeek.Saturday,
                DayOfWeek.Sunday
            };
            if (dayNum <= 7 && dayNum >= 1)
            {
            Console.WriteLine(daysInEnglish[dayNum-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day");
            }


        }
    }
}
