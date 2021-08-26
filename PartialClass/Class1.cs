using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Partialdemo
    {
        public void displaydata()
        {
            Console.WriteLine("The First Name is: {0}\nThe Last Name  is {1}", _fname, _lname);
        }
    }
}
