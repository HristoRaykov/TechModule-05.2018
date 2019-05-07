using System;

namespace _06._Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            long thiefID = 0;


            switch (numeralType)
            {
                case "sbyte":
                    byte sbyteMinDiff = byte.MaxValue;
                    for (int i = 0; i < n; i++)
                    {
                        if (sbyte.TryParse(Console.ReadLine(), out sbyte sbyteNum))
                        {
                            byte diff = (byte)(sbyte.MaxValue - sbyteNum);
                            if (diff < sbyteMinDiff)
                            {
                                sbyteMinDiff = diff;
                                thiefID = sbyteNum;
                            }
                        }
                    }
                    break;

                case "int":
                    uint intMinDiff = uint.MaxValue;
                    for (int i = 0; i < n; i++)
                    {
                        if (int.TryParse(Console.ReadLine(), out int intNum))
                        {
                            uint diff = (uint)(int.MaxValue - intNum);
                            if (diff < intMinDiff)
                            {
                                intMinDiff = diff;
                                thiefID = intNum;
                            }
                        }
                    }
                    break;

                case "long":
                    ulong longtMinDiff = ulong.MaxValue;
                    for (int i = 0; i < n; i++)
                    {
                        if (long.TryParse(Console.ReadLine(), out long longNum))
                        {
                            ulong diff = (ulong)(long.MaxValue - longNum);
                            if (diff < longtMinDiff)
                            {
                                longtMinDiff = diff;
                                thiefID = longNum;
                            }
                        }
                    }
                    break;
            }


            double sentence = 0;
            if (thiefID < 0)
            {
                sentence = thiefID / -128.0;
            }
            else
            {
                sentence = thiefID / 127.0;
            }

            if (sentence < 1)
            {
                Console.WriteLine($"Prisoner with id {thiefID} is sentenced to 1 year");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {thiefID} is sentenced to {Math.Ceiling(sentence)} years");
            }

        Console.ReadLine();
        }
    }
}
