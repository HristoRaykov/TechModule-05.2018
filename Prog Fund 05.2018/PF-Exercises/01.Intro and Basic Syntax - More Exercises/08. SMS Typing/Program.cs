using System;
using System.Text;

namespace _08._SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfChars = int.Parse(Console.ReadLine());
            StringBuilder sms = new StringBuilder();
            int num;
            int numOfDigits;
            int mainDigit;
            int aciiIndex;
            char ch;

            for (int i = 0; i < numberOfChars; i++)
            {
                num = int.Parse(Console.ReadLine());
                numOfDigits = getNumberOfDigits(num);
                mainDigit = num % 10;
                if (mainDigit == 0)
                {
                    ch = ' ';
                    sms.Append(ch);
                }
                else if (mainDigit==1)
                {
                    
                }
                else if (mainDigit==8 || mainDigit==9)
                {
                    aciiIndex = ((mainDigit - 2) * 3 + 1) + numOfDigits - 1 + 97;
                    ch = (char)aciiIndex;
                    sms.Append(ch);
                }
                else
                {
                    aciiIndex = ((mainDigit - 2) * 3) + numOfDigits - 1 + 97;
                    ch = (char)aciiIndex;
                    sms.Append(ch);
                }

            }

            Console.WriteLine(sms);
            Console.ReadLine();

        }

        public static int getNumberOfDigits(int number)
        {
            int numOfDigits = 1;
            while (number / 10 > 0)
            {
                numOfDigits++;
                number /= 10;
            }
            return numOfDigits;
        }
    }
}
