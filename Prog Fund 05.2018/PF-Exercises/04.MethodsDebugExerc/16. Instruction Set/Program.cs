using System;

namespace _16._Instruction_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long result = 0;
            while (input != "END")
            {
                string[] codeArgs = input.Split(' ');
                checked
                {
                    switch (codeArgs[0])
                    {
                        case "INC":
                            {
                                int operandOne = int.Parse(codeArgs[1]);
                                result = (long)operandOne + 1;
                                break;
                            }
                        case "DEC":
                            {
                                int operandOne = int.Parse(codeArgs[1]);
                                result = (long)operandOne - 1;
                                break;
                            }
                        case "ADD":
                            {
                                int operandOne = int.Parse(codeArgs[1]);
                                int operandTwo = int.Parse(codeArgs[2]);
                                result = (long)operandOne + operandTwo;
                                break;
                            }
                        case "MLA":
                            {
                                int operandOne = int.Parse(codeArgs[1]);
                                int operandTwo = int.Parse(codeArgs[2]);
                                result = (long)operandOne * operandTwo;
                                break;
                            }
                    }
                }
                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }
    }
}
