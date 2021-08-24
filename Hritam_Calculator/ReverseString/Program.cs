using System;

namespace ReverseString
{
    class Program
    {
        static string[] arr = new string[] { "Sunday", "Monday", "Tuesday", "Wednessday", "Thrusday", "Friday", "Saturday" };

        
        static void Main(string[] args)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
