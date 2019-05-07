using System;

namespace _06._DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int matchSum = int.Parse(Console.ReadLine());

            int counter = 0;
            int sum = 0;
            string sequence;
            char[] nucleicAcids =new char[] {'A', 'C','G','T'};
            for (int i1 = 1; i1 <= nucleicAcids.Length; i1++)
            {
                for (int i2 = 1; i2 <= nucleicAcids.Length; i2++)
                {
                    for (int i3 = 1; i3 <= nucleicAcids.Length; i3++)
                    {
                        sum = i1+i2+i3;
                        if (sum>=matchSum)
                        {
                            sequence = $"O{nucleicAcids[i1-1]}{nucleicAcids[i2-1]}{nucleicAcids[i3-1]}O";
                        }
                        else
                        {
                            sequence = $"X{nucleicAcids[i1-1]}{nucleicAcids[i2-1]}{nucleicAcids[i3-1]}X";
                        }                       
                        Console.Write(sequence+" ");
                        counter++;
                        if (counter%4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
