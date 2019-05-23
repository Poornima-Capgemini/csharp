using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 12, 5, 76, 23, 46, 225, 66 };
            var result = from e in a select e;
            Console.WriteLine("All elements are: ");
            foreach(var v in result)
            {
                Console.WriteLine(v);
            }

            var result2 = from e in a where e > 40 select e;
            Console.WriteLine("Filtered :");
            foreach (var v in result2)
            {
                Console.WriteLine(v);
            }

            var result3 = from e in a orderby e select e;
            Console.WriteLine("Sorted :");
            foreach (var v in result3)
            {
                Console.WriteLine(v);
            }

            var result4 = from e in a orderby e descending select e;
            Console.WriteLine("Sorted Descending:");
            foreach (var v in result4)
            {
                Console.WriteLine(v);
            }
        }
    }
}
