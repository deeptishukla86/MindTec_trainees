using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fill_handaling
{
    class Program
    {
        public void data()
        {
            StreamWriter sw = new StreamWriter("D://abc.txt");
            Console.WriteLine("enter the data you want in text file");
            string str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.data();
        }
    }
}
