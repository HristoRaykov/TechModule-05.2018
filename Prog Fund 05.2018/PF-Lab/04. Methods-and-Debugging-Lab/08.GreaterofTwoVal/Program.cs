using System;

namespace _08.GreaterofTwoVal
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int inputInt1 = int.Parse(Console.ReadLine());
                    int inputInt2 = int.Parse(Console.ReadLine());
                    int maxInt = GetMax(inputInt1,inputInt2);
                    Console.WriteLine(maxInt);
                    break;
                case "char":
                    char inputChar1 = char.Parse(Console.ReadLine());
                    char inputChar2 = char.Parse(Console.ReadLine());
                    char maxChar = GetMax(inputChar1, inputChar2);
                    Console.WriteLine(maxChar);
                    break;
                case "string":
                    string inputString1 = Console.ReadLine();
                    string inputString2 = Console.ReadLine();
                    string maxString = GetMax(inputString1, inputString2);
                    Console.WriteLine(maxString);
                    break;
            }

            
        }


        private static int GetMax(int inputInt1, int inputInt2)
        {
            if (inputInt1>=inputInt2)
            {
                return inputInt1;
            }
            else
            {
                return inputInt2;
            }
        }

        private static char GetMax(char inputString1, char inputString2)
        {
            if (inputString1.CompareTo(inputString2) >= 0)
            {
                return inputString1;
            }
            else
            {
                return inputString2;
            }
        }

        private static string GetMax(string inputString1, string inputString2)
        {
            if (inputString1.CompareTo(inputString2) >= 0)
            {
                return inputString1;
            }
            else
            {
                return inputString2;
            }
        }



    }
}
