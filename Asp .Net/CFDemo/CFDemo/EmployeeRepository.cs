using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CFDemo
{
    public class EmployeeRepository
    {
        public List<Department> GetDepartments()
        {
            EmployeeDBContext edbc = new EmployeeDBContext();
            return edbc.Departments.Include("Employees").ToList();

            //return edbc.Departments.Where(emp => emp.Location.Equals("Pune").ToList());
            /*var qry = from dep in edbc.Departments select dep;
            return qry.ToList();*/
            /*var qry = from dep in edbc.Departments
                      where dep.Location.Equals("Chennai")
                      select dep;
            return qry.ToList();*/
            
        }

        public List<Employee> GetEmployees()
        {
            EmployeeDBContext edbc = new EmployeeDBContext();
            var qry = from emp in edbc.Employees
                      where emp.FirstName.Equals("Shreya")
                      select emp;
            return qry.ToList();
        }
    }
}