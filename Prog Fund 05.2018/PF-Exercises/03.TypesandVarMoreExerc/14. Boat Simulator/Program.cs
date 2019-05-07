using System;

namespace _14._Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int distanceFistBoat = 0;
            int distanceSecondBoat = 0;
            int winner = 0;

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                if (input == "UPGRADE")
                {
                    firstBoat = Convert.ToChar(firstBoat + 3);
                    secondBoat = Convert.ToChar(secondBoat + 3);
                }
                else
                {
                    if (i % 2 == 1)
                    {
                        distanceFistBoat += input.Length;
                        if (distanceFistBoat >= 50)
                        {
                            winner = 1;
                            break;
                        }
                    }
                    else
                    {
                        distanceSecondBoat += input.Length;
                        if (distanceSecondBoat >= 50)
                        {
                            winner = 2;
                            break;
                        }
                    }
                }

            }

            if (winner == 1)
            {
                Console.WriteLine(firstBoat);
            }
            else if (winner == 2)
            {
                Console.WriteLine(secondBoat);
            }
            else if (winner == 0)
            {
                if (distanceFistBoat > distanceSecondBoat)
                {
                    Console.WriteLine(firstBoat);
                }
                else if (distanceSecondBoat > distanceFistBoat)
                {
                    Console.WriteLine(secondBoat);
                }
            }


        }
    }
}
