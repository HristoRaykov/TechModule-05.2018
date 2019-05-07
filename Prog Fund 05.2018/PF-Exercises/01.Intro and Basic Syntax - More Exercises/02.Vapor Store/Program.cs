using System;

namespace _02.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {            
            double initialBalance = double.Parse(Console.ReadLine());
            double remainingBalance = initialBalance;
            string input = Console.ReadLine(); 
            while (input.ToLower()!="game time")
            {
                switch (input.ToLower())
                {
                    case "outfall 4":                                                                     
                        if (remainingBalance>=39.99)
                        {
                            remainingBalance -= 39.99;
                            Console.WriteLine("Bought OutFall 4");
                        }                        
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }                        
                            break;
                    case "cs: og":                        
                        if (remainingBalance >= 15.99)
                        {
                            remainingBalance -= 15.99;
                            Console.WriteLine("Bought CS: OG");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        break;
                    case "zplinter zell":
                        if (remainingBalance >= 19.99)
                        {
                            remainingBalance -= 19.99;
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        break;
                    case "honored 2":
                        if (remainingBalance >= 59.99)
                        {
                            remainingBalance -= 59.99;
                            Console.WriteLine("Bought Honored 2");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        break;
                    case "roverwatch":
                        if (remainingBalance >= 29.99)
                        {
                            remainingBalance -= 29.99;
                            Console.WriteLine("Bought RoverWatch");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        break;
                    case "roverwatch origins edition":
                        if (remainingBalance >= 39.99)
                        {
                            remainingBalance -= 39.99;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");                        
                        break;
                }


                if (remainingBalance == 0)
                {                   
                    break;
                }
                input = Console.ReadLine();
            }

            if (remainingBalance == 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${(initialBalance-remainingBalance):f2}. Remaining: ${remainingBalance:f2}");
            }

            
        }
    }
}
