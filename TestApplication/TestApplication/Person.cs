using System;
using System.Collections.Generic;
using System.Text;

namespace TestApplication
{
    public class Person
    {

        public List<Person> persons = null;


        public Person(bool flag)
        {
            getpersons();
        }

        public Person()
        {

        }

        public int CityID { set; get; }
        public string Name { set; get; }


        public  List<Person> getpersonlist()
            {
            return persons;
            }


        private void getpersons()
        {
            var list = new List<Person>();

            for (var i = 0; i < 10; i++)
            {
                list.Add(new Person { CityID = i, Name = "Name" + i });
            }

            persons = list;
        }
      }
}
