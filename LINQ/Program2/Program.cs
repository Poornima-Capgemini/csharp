using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]
            {
                "Sangeetha","Jithendra","Sai","Siva","Arun","Pallavi","Dhivya","Aruna"
            };
            var result1 = from e in names select e;
            Console.WriteLine("Names are :");
            foreach (var v in result1)
            {
                Console.WriteLine(v);
            }
            var result2 = from e in names where e.StartsWith("S") select e;
            Console.WriteLine("\r\nFiltered :");
            foreach (var v in result2)
            {
                Console.WriteLine(v);
            }
            var result3 = from e in names orderby e select e;
            Console.WriteLine("\r\nSorted :");
            foreach (var v in result3)
            {
                Console.WriteLine(v);
            }

            var result4 = from e in names orderby e descending select e;
            Console.WriteLine("\r\nSorted :");
            foreach (var v in result4)
            {
                Console.WriteLine(v);
            }

        }
    }
}
