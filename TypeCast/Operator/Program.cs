using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            object obj = arr[1];
            //string str = (string)obj;
            string str = obj as string;
                
            if(str!=null)
            {
                Console.WriteLine("successful casted");

            }
            else
            {
                Console.Write("not successful casting ");
                Console.WriteLine();
            }
            Console.WriteLine("after casting :" + str);
        }
        
    }
}
