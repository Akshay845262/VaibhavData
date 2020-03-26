using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDBFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDBEntities context = new EmployeeDBEntities();
            var employee1 = context.Employees;
            var employee2 = context.Employees;
            /*employee1.Add(new Employee { EmpID = 1, Name = "VaibhavRaj", salary = 22000, DepID = 3 });*/
            employee2.Add(new Employee { EmpID = 2, Name = "Shreya", salary = 22000, DepID = 3 });

            context.SaveChanges();
            Console.ReadKey();
        }
    }
}
