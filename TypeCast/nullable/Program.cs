using System;

namespace nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable <int> a = null;
            Console.WriteLine(a);

            int b = null;
            Console.WriteLine(b);
        }
    }
}
