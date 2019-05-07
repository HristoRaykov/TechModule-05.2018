using System;

namespace _01._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = Console.ReadLine();
            string text2 = Console.ReadLine();

            string commanStart = GetCommanStart(text1, text2);
            string commanEnd = GetCommanEnd(text1,text2);

            int wordCountStart = GetWordCount(commanStart);
            int wordCountEnd = GetWordCount(commanEnd);
            int result = Math.Max(wordCountEnd,wordCountStart);

            
            Console.WriteLine(result);
        }

        private static string GetCommanEnd(string text1, string text2)
        {
            int minLength = Math.Min(text1.Length, text2.Length);
            int maxLength = Math.Max(text1.Length, text2.Length);
            int diff = maxLength - minLength;
            int maxComEnd = 0;

            for (int index = minLength - 1; index >= 0; index--)
            {

                if (text1.Length >= text2.Length)
                {
                    if (text1[index + diff] == text2[index])
                    {
                        maxComEnd++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    if (text1[index] == text2[index + diff])
                    {
                        maxComEnd++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            string commanEnd = text1.Substring(text1.Length - maxComEnd).Trim();
            return commanEnd;
        }

        private static string GetCommanStart(string text1, string text2)
        {
            int minLength = Math.Min(text1.Length, text2.Length);
            int maxComStart = 0;
            for (int index = 0; index < minLength; index++)
            {
                if (text1[index] == text2[index])
                {
                    maxComStart++;
                }
                else
                {
                    break;
                }
            }
            string commanStart = text1.Substring(0, maxComStart).Trim();
            return commanStart;
        }

        private static int GetWordCount(string str)
        {
            int wordCount = str.Trim().Split(' ',StringSplitOptions.RemoveEmptyEntries).Length;
            return wordCount;
        }
    }
}
