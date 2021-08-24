using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(RevString(str));
        }

        private static string RevString(string str)
        {
            string revStr = "";
            int length = str.Length - 1;
            while (length >= 0)
            {
                revStr = revStr + str[length];
                length--;
            }
            return revStr;
        }
    }
}
