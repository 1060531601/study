using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace TestApplication
{

    class Program
    {
        static void Main(string[] args)
        {

            var intnum = Convert.ToInt32("2,220");

            var intnum1 = Convert.ToInt32("2,220");
            var intnum2 = Convert.ToInt32("2,220");

            var  dateTo = new DateTime?();

            try
            {
               dateTo = new DateTime(2001, 0, 0);
            }
            catch (Exception e)
            {
                dateTo =  null;
            }


            var defaulttime = default(DateTime);

            var mintime = DateTime.MinValue;


            var lissssst = new Person(true);

            var personsss = lissssst.getpersonlist();

            Person[] persons = new Person[]
             {
        new Person{ CityID = 1, Name = "ABC" },
        new Person{ CityID = 1, Name = "EFG" },
        new Person{ CityID = 2, Name = "HIJ" },
        new Person{ CityID = 3, Name = "KLM" },
        new Person{ CityID = 3, Name = "NOP" },
        new Person{ CityID = 4, Name = "QRS" },
        new Person{ CityID = 5, Name = "TUV" }
             };
            
            var listPersons = new List<Person>();
            listPersons.AddRange(persons);
            var liPerson = listPersons.FirstOrDefault();

            listPersons.Remove(listPersons.FirstOrDefault());



            var intarry = new int[5];


            var datears = DateTime.Now;

            var monars = datears.Month;

            var dayars = datears.Day;

            var settings = new PrinterSettings();

            var Paper = new PaperSize();

            var kind = ((int)PaperKind.A5);

            var paperkind = ((int)PaperKind.A5).ToString();

            Paper.RawKind = kind;
            settings.DefaultPageSettings.PaperSize = Paper;

            var paints = new List<int>();

            paints.Add(1);

            var strpaint = String.Join(',', paints.ToArray());

            var datetime = DateTime.Now.ToString("yyyyMMdd");

            City[] cities = new City[]
            {
        new City{ ID = 10,Name = "Guangzhou" },
        new City{ ID = 20,Name = "Shenzhen" },
        new City{ ID = 30,Name = "Beijing" },
        new City{ ID = 40,Name = "Shanghai" }
            };

            var result222 = persons.Join(cities,
            p => p.CityID,
            c => c.ID,
            (p, cs) => new {
                PersonName = p.Name,
                Citys = cs
            });


            var result = persons.GroupJoin(cities,
            p => p.CityID ,
            c => c.ID ,
            (p, cs) => new
            {
                PersonName = p.Name,
                Citys = cs
            });

            foreach (var res in result)
            {

            }






            var students = new List<Student>();

            students.AddRange(new Student[] {
            new Student("日本"){name = "wangdachui",age=10,index=10 ,Sex="male"},
            new Student("中國"){name = "liudachui",age=20,index=9 ,Sex="female"},
            new Student("アメリカ"){name = "wangdachui",age=30,index=8,Sex="male" },
            new Student("イギリス"){name = "liudachui",age=40,index=7 ,Sex="female"},
            new Student("ドイツ"){name = "chengdachui",age=10,index=6 ,Sex="male"},
            });


            var tolookup = students.ToLookup(r => r.Sex).Select(r => r.Key);

            var trueforall = students.TrueForAll(r => r.Sex.ToLower().Equals("male"));

            var date = DateTime.Now;

            var sdate = date.ToString("MM/dd");

            var listt = students.GroupBy(r => r.age)
                .OrderByDescending(r => r.Key);
              


            var list = students.GroupBy(r => new { r.name, r.age,r.index });

            var list1 = students.GroupBy(r => new { r.name });

            var list2 = students.GroupBy(r => new { r.age });

            if (true)
            {
                int index = 0;
                foreach (var li in list1)
                {
                    foreach (var temp in li)
                    {
                     index += temp.index;
                    }
                }

            }
            if (true)
            {
                int index = 0;
                foreach (var li in list)
                {
                    foreach (var temp in li)
                    {
                        index += temp.index;

                    }
                }

            }

            if (true)
            {
                int index = 0;
                foreach (var li in list2)
                {
                    foreach (var temp in li)
                    {
                        index += temp.index;
                    }
                }

            }


        }

        private static DateTime getTime(DateTime date)
        {
            DateTime returnDateTime =  date;

            int i = 0;

            while (i <= 5)
            {
               // returnDateTime.AddDays(1);
                date = date.AddDays(1);
                i++;
            }

            return returnDateTime;
        }


        private static void setStudent(Student student)
        {
            student.age = 18;

        
        }

    }

}
