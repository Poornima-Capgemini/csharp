using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employ> lstEmploy = new List<Employ>()
           {
               new Employ{Empno=1,Name="Jithu",Dept="Dotnet",Desig="Devloper",Basic=88234},
               new Employ{Empno=2,Name="Ram",Dept="SQL",Desig="Programmer",Basic=63244},
               new Employ{Empno=3,Name="Sada",Dept="Dotnet",Desig="Devloper",Basic=36778},
               new Employ{Empno=4,Name="Anitha",Dept="SQL",Desig="Admin",Basic=44365},
               new Employ{Empno=5,Name="Arun",Dept="Dotnet",Desig="Devloper",Basic=78333}
           };
            var result = from e in lstEmploy select e;
            Console.WriteLine("All Employees ");
            foreach(var v in result)
            {
                Console.WriteLine(v.Empno+" "+v.Name+" "+v.Dept+" "+v.Desig+" "+v.Basic);
            }

            var result1 = from e in lstEmploy select new { e.Empno, e.Name, e.Basic };
            Console.WriteLine("\r\nProjected Fieds ");
            foreach (var v in result1)
            {
                Console.WriteLine(v.Empno + " " + v.Name + " "+ v.Basic);
            }

            var result2 = from e in lstEmploy where e.Basic >= 5000 select e;
            Console.WriteLine("\r\nFiltered Records ");
            foreach (var v in result2)
            {
                Console.WriteLine(v.Empno + " " + v.Name + " " + v.Dept + " " + v.Desig + " " + v.Basic);
            }

            var result4 = from e in lstEmploy orderby e.Name select e;
            Console.WriteLine("\r\nSorted Employees ");
            foreach (var v in result4)
            {
                Console.WriteLine(v.Empno + " " + v.Name + " " + v.Dept + " " + v.Desig + " " + v.Basic);
            }
        }
    }
}
