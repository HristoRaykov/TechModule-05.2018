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
                    Console.WriteLine(thiefID);
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
                    Console.WriteLine(thiefID);
                    break;

                case "long":
                    ulong longtMinDiff = ulong.MaxValue;
                    for (int i = 0; i < n; i++)
                    {
                        if (long.TryParse(Console.ReadLine(), out long longNum))
                        {
                            ulong diff =(ulong)(long.MaxValue - longNum);
                            if (diff < longtMinDiff)
                            {
                                longtMinDiff = diff;
                                thiefID = longNum;
                            }
                        }
                    }
                    Console.WriteLine(thiefID);
                    break;
            }


        }
    }
}
