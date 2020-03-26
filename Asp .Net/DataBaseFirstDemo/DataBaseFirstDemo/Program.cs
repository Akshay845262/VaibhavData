using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataBaseFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new EmployeeDBEntities())
            {
                var query = from b in db.Employees 
                            orderby b.FirstName
                            select b;
                Console.WriteLine("All Employees in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
