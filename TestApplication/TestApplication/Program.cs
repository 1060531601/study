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

            //string[] dates = new string[] { "5", "6", "3" };
            //var result = getDates(dates, DateTime.Now, "00000001");

            var leftlist = new List<Person> { new Person { CityID = 1, Name = "wangdachui1" }, 
                                              new Person { CityID = 2, Name = "wangdachui2" } };

            var fukulist = new List<Patient> { new Patient { id = 1, Name = "wangdachui1" }, 
                                               new Patient { id = 2, Name = "wangdachui3" }, 
                                               new Patient { id = 3, Name = "wangdachui4" },
                                               new Patient { id = 4, Name = "wangdachui1" } };

            var resultL = fukulist.GroupJoin(leftlist,
                 fuku => fuku.Name,
                 left => left.Name,
                 (fukuL, leftL) => new
                 {
                     fukuL,
                     leftL
                 }).Select(r => new LeftJoin {
                     FukuName = r.fukuL.Name,
                     Persons = r.leftL.ToList(),
                     id = r.fukuL.id});

            foreach (var rL in resultL)
            {
                if (rL.Persons.Any())
                {
                    foreach (var r in rL.Persons)
                    {
                        Console.WriteLine(rL.id + "=>" + rL.FukuName + "=>" + r.CityID + "=>" + r.Name);
                    }
                }
                else 
                {
                    Console.WriteLine(rL.id + "=>" + rL.FukuName + "=> null => null" );
                }
                
                
            }


        }

        public static string[] getDates(string[] dates, DateTime date, string code)
        {
            return dates.Take(3).Select(d => getDate(date, int.Parse(d), code)).ToArray();
        }

        public static string getDate(DateTime date, int num, string code)
        {
            IEnumerable<int> Genrenal(int index)
            {
                int value = index;
                while (true)
                {
                    yield return value++;
                }
            }

            return Genrenal(num).Select(r => date.AddDays(-1 * r)).First(day => isClose(date, code) == false).ToString();
        }

        public static bool isClose(DateTime date, string code)
        {
            var random = new Random().Next(1, 11);

            if (date.Day * random > 70)
            {
                return false;
            }
            return true;
        }
    }
}
