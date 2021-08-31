using System;

namespace SolidExe
{
    public interface First
    {
        void data();

    }

    
    public interface Invoice
    {

        void addinvoice();

    }
    public class invoice : Invoice
    {

        public int rem = 3;
        public int sum = 0;
        public void addinvoice()
        {
            for (int i = 0; i < rem; i++)
            {

                Console.WriteLine("enter the amount :");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a <= 5000)
                {
                
                    sum = sum + a;
                }
                Console.WriteLine("total amount is :" + sum);
                
            }
            Console.WriteLine();
        }

       
        public void display()
        {
            Console.WriteLine("welcome!!");
            Console.WriteLine();
        }
        class Second : First
        {
            public void data()
            {
                Console.WriteLine("");
            }
        }

        static void Main(string[] args)
        {

            invoice i = new invoice();
            
            i.addinvoice();
         
            i.display();
        }
    }

}
