using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
 
namespace Linq
{
    class Program
    {
        static void EmpDepTwoTableQuery()
        {
            DataSet1 eds = new DataSet1();
            DataSet1TableAdapters.EmployeeTableAdapter empTableAdapter = new DataSet1TableAdapters.EmployeeTableAdapter();
            empTableAdapter.Fill(eds.Employee);

            DataSet1Adapters.DepartmentsTableAdapter departmentTableAdapter = new DataSet1TableAdapters.DepartmentsTableAdapter();
            departmentTableAdapter.Fill(eds.Departments);

            var query = from emp in eds.Employee
                        join dep in eds.Departments on emp.DID equals dep.DID
                        orderby emp.ID
                        select new
                        {
                            EmployeeID = emp.ID,
                            EmployeeName = emp.Name,
                            EmployeeDepartment = dep.DID,
                            EmployeeDepartmentName = dep.DeptName,
                            EmployeeSalary = emp.Salary,

                        };
            foreach (var item in query)
            {
                Console.WriteLine("{0}", item.EmployeeID);
                Console.WriteLine("{0}", item.EmployeeName);
                Console.WriteLine("{0}", item.EmployeeDepartment);
                Console.WriteLine("{0}", item.EmployeeDepartmentName);
                Console.WriteLine("{0}", item.EmployeeSalary);

            }

        }
        static void Main()
        {
            EmpDepTwoTableQuery();
        }
    }
}

