using System;
using System.Collections.Generic;

namespace _17._Be_Positive
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int currSequence = 0; currSequence < countSequences; currSequence++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                List<int> numbers = new List<int>();

                for (int currIndex = 0; currIndex < input.Length; currIndex++)
                {
                    if (!input[currIndex].Equals(string.Empty))
                    {
                        int num = int.Parse(input[currIndex]);
                        numbers.Add(num);
                    }
                }

                bool hasPositive = false;

                for (int index = 0; index < numbers.Count; index++)
                {
                    int currentNum = numbers[index];
                    if (index < numbers.Count -1)
                    {
                        if (currentNum >= 0)
                        {
                            if (hasPositive)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(currentNum);
                            hasPositive = true;
                        }
                        else
                        {
                            currentNum += numbers[index + 1];
                            index++;
                            if (currentNum >= 0)
                            {
                                if (hasPositive)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(currentNum);
                                hasPositive = true;
                            }
                        }
                    }
                    else
                    {
                        if (currentNum >= 0)
                        {
                            if (hasPositive)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(currentNum);
                            hasPositive = true;
                        }
                    }
                    
                }

                if (hasPositive)
                {
                    Console.WriteLine();                    
                }
                else
                {
                    Console.WriteLine("(empty)");
                }
            }


        }
    }
}
