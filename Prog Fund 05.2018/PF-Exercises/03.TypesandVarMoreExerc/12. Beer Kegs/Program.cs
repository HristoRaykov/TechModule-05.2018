using System;

namespace _12._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxVolume = 0;
            string maxVolModel = "";
            double r = 0;
            string model = "";
            int height = 0;

            for (int i = 1; i <= n; i++)
            {

                for (int k = 1; k <= 3; k++)
                {
                    switch (k)
                    {
                        case 1:
                            model = Console.ReadLine();
                            break;
                        case 2:
                            r = double.Parse(Console.ReadLine());
                            break;
                        case 3:
                            height = int.Parse(Console.ReadLine());
                            break;
                    }                
                }
                double volume = Math.PI * r * r * height;
                if (maxVolume < volume)
                {
                    maxVolume = volume;
                    maxVolModel = model;
                }
            }
            Console.WriteLine(maxVolModel);
        }
    }
}
