using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data source
            string[] names = { "Bill", "Steve", "James", "Mohan" };

            // LINQ Query 
            var myLinqQuery = from naam in names
                              where naam.Contains('a')
                              select naam;

            // Query execution
            foreach (var name in myLinqQuery)
                Console.Write(name + " ");
            Console.ReadKey();
        }
    }
}
