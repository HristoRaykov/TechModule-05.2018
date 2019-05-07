using System;

namespace _01._Blank_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

        static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT\n------------------------------");
        }

        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________\n" +
                "Received by___________________");
        }

        static void PrintFooter()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
            
        }


    }
}
