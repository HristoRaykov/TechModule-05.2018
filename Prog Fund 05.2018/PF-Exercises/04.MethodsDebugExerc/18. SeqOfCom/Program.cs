using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main(string[] args)
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string line = Console.ReadLine().Trim();
        int[] numArguments = new int[2];
        string[] stringParams = line.Split(ArgumentsDelimiter);
        string command = stringParams[0];

        while (!command.Equals("stop"))
        {
            if (command.Equals("add") ||
                command.Equals("subtract") ||
                command.Equals("multiply"))
            {

                numArguments[0] = int.Parse(stringParams[1]);
                numArguments[1] = int.Parse(stringParams[2]);

                array = PerformAction(array, command, numArguments);
            }
            else if (command.Equals("lshift"))
            {
                array = ArrayShiftLeft(array);
            }
            else if (command.Equals("rshift"))
            {
                array = ArrayShiftRight(array);
            }



            PrintArray(array);
            Console.WriteLine();

            line = Console.ReadLine().Trim();
            stringParams = line.Split(ArgumentsDelimiter);
            command = stringParams[0];
        }
    }

    static long[] PerformAction(long[] arr, string command, int[] arguments)
    {
        long[] array = arr.Clone() as long[];
        int index = arguments[0] - 1;
        int value = arguments[1];
        checked
        {
            switch (command)
            {
                case "multiply":
                    array[index] *= value;
                    break;
                case "add":
                    array[index] += value;
                    break;
                case "subtract":
                    array[index] -= value;
                    break;
            }
        }
        return array;
    }

    private static long[] ArrayShiftRight(long[] array)
    {
        long[] shiftedArray = new long[array.Length];
        shiftedArray[0] = array[array.Length - 1];
        for (int i = 0; i < array.Length - 1; i++)
        {
            shiftedArray[i + 1] = array[i];
        }
        return shiftedArray;
    }

    private static long[] ArrayShiftLeft(long[] array)
    {
        long[] shiftedArray = new long[array.Length];
        shiftedArray[shiftedArray.Length - 1] = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            shiftedArray[i-1] = array[i];
        }
        return shiftedArray;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

    }
}
