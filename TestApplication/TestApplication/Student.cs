using System;
using System.Collections.Generic;
using System.Text;

namespace TestApplication
{
    public class Student
    {

        public string _country { get; }
        public string name { get; set; }

        public int age { get; set; }

        public int index { get; set; }

        public string Sex { get; set; }

        public DateTime Date { get; set; }


        public Student(string country)
        {
            _country = country;
        }
    }
}
