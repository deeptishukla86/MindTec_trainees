using System;

namespace CustomException
{
    public delegate void AddDelegate(int a,int b);
    public class bank
    {
         
        
        public void add(int rem,int sum)
        {
            
            for (int i = 1; i <= rem; i++)
                {
                    Console.WriteLine("enter the amount to be added : ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    if (a <= 50000)
                    {
                        sum = sum + a;
                        Console.WriteLine("total amount : " + sum);
                        Console.WriteLine();
                    }
                    else
                    {
                    Console.WriteLine();
                    Console.WriteLine("Remaining amount :" + sum);
                        throw (new account("PLEASE enter amount < 50000"));

                    }
                }
            
        }

        public class account : Exception
        {
            public account(string Msg) : base(Msg)
            {
                
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                
                bank b = new bank();
                AddDelegate ad = new AddDelegate(b.add);

                try
                {
                 ad(0);
                 ad(3);

                }
                catch(account e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
