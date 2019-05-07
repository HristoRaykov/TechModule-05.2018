using System;

namespace _15._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isBalanced = true;
            
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    counter++;
                }
                else if (input == ")")
                {
                    counter--;
                }

                if (counter<0 || counter>1)
                {
                    isBalanced = false;
                    break;
                }
            }

            if (counter != 0)
            {
                isBalanced = false;
            }

            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
