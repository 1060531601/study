using System;
using System.Collections.Generic;
using System.Text;

namespace TestApplication
{
    public class Patient : Student
    {
        public int id { set; get; }

        public Patient(string country) : base(country)
        {

        }
    }
}
