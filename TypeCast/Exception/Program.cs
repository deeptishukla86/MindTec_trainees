using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
                System.Console.WriteLine("answer is " + c);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.message);
            }
            finally
            {
                Console.WriteLine("solved");
            }
        }
    }
}
