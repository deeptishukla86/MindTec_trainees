﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Partialdemo
    {
        private string _fname;
        private string _lname;
        public string fname
        {
            get
            {
                return _fname;
            }
            set
            {

                _fname = value;
            }

        }
        public string lname
        {
            get
            {
                return _lname;
            }
            set
            {
                _lname = value;
            }

        }
    }
}
