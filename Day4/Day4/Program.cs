using System;

namespace Day4
{
    public class Program : IDisposable
    {

        ~Program()
        {
        }
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
    class program1
    {
        static void Main(string[] args)
        {

            for (int a = 0; a < 10; a++)
            {
                Program p = new Program();
                p.Dispose();

            }
        }
    }
}


