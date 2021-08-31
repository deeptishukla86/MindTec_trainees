using System;
using System.Collections;

namespace ArrayCollection
{
    class Program
   {
       static void Main(string[] args)
       {
          //Createing ArrayList collection using default constructor
           ArrayList al = new ArrayList();
           Console.WriteLine("Initial Capacity: " + al.Capacity);
           al.Add(10);
           Console.WriteLine("Capacity after adding first item: " + al.Capacity);
           al.Add("hello");
           al.Add(true);
            Console.WriteLine("Capacity after adding 3rd element: " + al.Capacity);
            al.Add(3.14f);
           Console.WriteLine("Capacity after adding fourth item: " + al.Capacity);
           al.Add('A');
           Console.WriteLine("Capacity after adding 5th element: " + al.Capacity);
            al.Add('B');
            Console.WriteLine("Capacity after adding 6th element: " + al.Capacity);
            al.Add('c');
            Console.WriteLine("Capacity after adding 7th element: " + al.Capacity);
            al.Add('d');
            Console.WriteLine("Capacity after adding 8th element: " + al.Capacity);
            al.Add('e');
            Console.WriteLine("Capacity after adding 9th element: " + al.Capacity);
            //Printing the ArrayList elements using for loop
            for (int i = 0; i < al.Count; i++)
           {
               Console.Write(al[i] + "  ");
           }
           Console.WriteLine();
          //Removing the values from the middle of the array list
          //here we are removing by value
           al.Remove(10);
          //You can also remove element by using index position
          al.RemoveAt(2);
          //Printing the ArrayList elements using foreach loop after
          // removing an element from the collection
           foreach (object obj in al)
           {
               Console.Write(obj + "  ");
           }
           Console.WriteLine();

          //inserting values into the middle of the array list collection
           al.Insert(6, true);
          // Printing the values of the collection using foreach loop after
          // inserting an element into the middle of the collection
           foreach (object obj in al)
           {
               Console.Write(obj + "  ");
           }
           Console.WriteLine();
          // creating new ArrayList collection by passing the old
          // array list as parameter
           ArrayList coll = new ArrayList(al);
           Console.WriteLine("Initial capacity of new array list collection:" + coll.Capacity);
          // Printing the values of the new array list collection using foreach loop
           foreach (object obj in coll)
           {
               Console.Write(obj + "  ");
           }
           Console.ReadKey();
       }
   }

}
