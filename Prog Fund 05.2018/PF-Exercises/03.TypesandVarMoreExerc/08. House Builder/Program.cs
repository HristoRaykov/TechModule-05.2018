using System;

namespace _08._House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            int intNum;
            if (sbyte.TryParse(str1, out sbyte sbyteNum))
            {
                
                intNum = int.Parse(str2);
            }
            else
            {
                intNum = int.Parse(str1);
                sbyteNum = sbyte.Parse(str2);
            }
            ulong totalPrice = 4u * (ulong)sbyteNum + 10u * (ulong)intNum;
            Console.WriteLine(totalPrice);
        }
    }
}
