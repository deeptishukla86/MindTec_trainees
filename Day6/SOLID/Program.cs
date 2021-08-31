using System;

namespace SOLID
{
    public interface IEail
    {
        void Email1();

    }
    public interface Invoice
    {
        public void add();

      
    }
    public class AddIn:Invoice
    {
        public void add()
        {
            Console.WriteLine("hi!!");

        }
        public void del()
        {
            Console.WriteLine("hi hello!!");

        }
        class Email : IEail
        {
            public void Email1()
            {
                Console.WriteLine("send fist mail");
            }
        }
    }
   
    
   
    class Program
    {
        static void Main(string[] args)
        {
          AddIn obj = new AddIn();
            obj.add();
            obj.del();

        }
    }
}
