using System;

namespace _18._Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            
            int counter = 0;
            bool isFittingSbyte = true;
            try
            {
                sbyte sbytNum = sbyte.Parse(inputNum);
                counter++;
            }
            catch (Exception)
            {
                isFittingSbyte = false;
            }           

            bool isFittingByte = true;
            try
            {
                byte byteNum = byte.Parse(inputNum);
                counter++;
            }
            catch (Exception)
            {
                isFittingByte = false;
            }

            bool isFittingShort = true;
            try
            {
                short shortNum = short.Parse(inputNum);
                counter++;
            }
            catch (Exception)
            {
                isFittingShort = false;
            }

            bool isFittingUshort = true;
            try
            {
                ushort ushortNum = ushort.Parse(inputNum);
                counter++;
            }
            catch (Exception)
            {
                isFittingUshort = false;
            }

            bool isFittingInt = true;
            try
            {
                int intNum = int.Parse(inputNum);
                counter++;
            }
            catch (Exception)
            {
                isFittingInt = false;
            }

            bool isFittingUint = true;
            try
            {
                uint suintNum = uint.Parse(inputNum);
                counter++;
            }
            catch (Exception)
            {
                isFittingUint = false;
            }

            bool isFittingLong = true;
            try
            {
                long longNum = long.Parse(inputNum);
                counter++;
            }
            catch (Exception)
            {
                isFittingLong = false;
            }


            if (counter == 0)
            {
                Console.WriteLine($"{inputNum} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{inputNum} can fit in:");
                if (isFittingSbyte)
                {
                    Console.WriteLine("* sbyte");
                }
                if (isFittingByte)
                {
                    Console.WriteLine("* byte");
                }
                if (isFittingShort)
                {
                    Console.WriteLine("* short");
                }
                if (isFittingUshort)
                {
                    Console.WriteLine("* ushort");
                }
                if (isFittingInt)
                {
                    Console.WriteLine("* int");
                }
                if (isFittingUint)
                {
                    Console.WriteLine("* uint");
                }
                if (isFittingLong)
                {
                    Console.WriteLine("* long");
                }
            }
        }
    }
}
