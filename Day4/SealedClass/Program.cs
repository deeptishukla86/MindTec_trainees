using System;

namespace SealedClass
{
    public class Transport
    {
        public void display() {
            Console.WriteLine("This is vehicle chart");
          }
        }
    public sealed class FourWheel : Transport
    {

        public void display()
        {
            Console.WriteLine("this is four wheeler");

        }
    }
    public sealed class TwoWheel : Transport
    {

        public void display()
        {
            Console.WriteLine("this is two wheeler ");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Transport t = new TwoWheel();
            t.display();
            Transport t1 = new FourWheel();
            t1.display();
        }
    }
}


