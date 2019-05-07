using System;

namespace _04._Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            double imperialValue = double.Parse(Console.ReadLine());

            string metricUnit = "";
            double metriclValue = 0;

            switch (imperialUnit)
            {
                case "miles":
                    metriclValue = imperialValue * 1.6;
                    metricUnit = "kilometers";
                    break;
                case "inches":
                    metriclValue = imperialValue * 2.54;
                    metricUnit = "centimeters";
                    break;
                case "feet":
                    metriclValue = imperialValue * 30;
                    metricUnit = "centimeters";
                    break;
                case "yards":
                    metriclValue = imperialValue * 0.91;
                    metricUnit = "meters";
                    break;
                case "gallons":
                    metriclValue = imperialValue * 3.8;
                    metricUnit = "liters";
                    break;
            }

            Console.WriteLine($"{imperialValue} {imperialUnit} = {metriclValue:f2} {metricUnit}");
        }
    }
}
