using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder(Console.ReadLine());
            StringBuilder reversed = new StringBuilder();
            int lastIndex = str.Length - 1;
            for (int i = 0; i < str.Length; i++)
            {
                reversed.Append(str[lastIndex - i]);
            }

            Console.WriteLine(reversed);


        }
    }
}
