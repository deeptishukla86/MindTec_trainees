using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface One
    {
        void Odd();
        void One();
        void Three();
        void Five();
    }
    public interface Two
    {
        void Even();
        void Two();
        void Four();
        void Six();
    }
    public class three : One, Two
    {
        public void Odd()
        {
            Console.WriteLine("Odd");
        }
        public void One()
        {
            Console.WriteLine("One");
        }
        public void Three()
        {
            Console.WriteLine("Three");
        }
        public void Five()
        {
            Console.WriteLine("Five");
            Console.WriteLine();
            Console.WriteLine();
        }
        public void Even()
        {
            Console.WriteLine("Even");
        }
        public void Two()
        {
            Console.WriteLine("Two");
        }
        public void Four()
        {
            Console.WriteLine("Four");
        }
        public void Six()
        {
            Console.WriteLine("Six");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            One o;
            o = new three();
            o.Odd();
            o.One();
            o.Three();
            o.Five();
            Two t;
            t = new three();
            t.Even();
            t.Two();
            t.Four();
            t.Six();
            Console.ReadLine();
        }
    }
}
