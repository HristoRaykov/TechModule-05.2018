using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _firstDate.Year1.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holidays = new DateTime[] 
            {
                new DateTime(firstDate.Year,1,1), new DateTime(firstDate.Year, 3, 3), new DateTime(firstDate.Year, 5, 1),
                new DateTime(firstDate.Year, 5, 6), new DateTime(firstDate.Year,5,24),new DateTime(firstDate.Year,9,6), new DateTime(firstDate.Year,9,22),
                new DateTime(firstDate.Year, 11, 1),new DateTime(firstDate.Year, 12, 24),new DateTime(firstDate.Year, 12, 25),new DateTime(firstDate.Year, 12, 26),
                
            };

            int workingdays = 0;

            for (DateTime date = firstDate; date<=secondDate; date = date.AddDays(1))
            {                
                bool isSaturday = date.DayOfWeek.Equals(DayOfWeek.Saturday);
                bool isSunday = date.DayOfWeek.Equals(DayOfWeek.Sunday);
                bool isHoliday = holidays.Select(d=>d.DayOfYear).Contains(date.DayOfYear);  
                
                bool isWorking = !isSaturday && !isSunday && !isHoliday;
                
                if (isWorking)
                {
                    workingdays++;                                       
                }
            }

            Console.WriteLine(workingdays);
        }   
    }
}
