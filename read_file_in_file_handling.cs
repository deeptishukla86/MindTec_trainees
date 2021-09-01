using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file_handaling_exp2
{
    class Program
    {
        public void data()
        {
            StreamReader sw = new StreamReader("D://abc.txt");
            Console.WriteLine("content of you filee");
            //string str = Console.ReadLine();
            //sw.WriteLine(str);
            //sw.Flush();
            sw.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sw.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sw.ReadLine();
            }

            sw.Close();
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.data();
        }
    }
}
