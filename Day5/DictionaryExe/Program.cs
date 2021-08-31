using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryExe
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<Int16, string> d = new Dictionary<Int16, string>();
            d.Add(102,"asd");
            d.Add(103,"abhi");
            d.Add(105,"akshay");
            d.Add(101,"rohi" );

            foreach (KeyValuePair<Int16, string> a in d.OrderBy(key => key.Value))
            {
                Console.WriteLine("Key {0} : value {1}", a.Key, a.Value);
            }


        }
    }
}
