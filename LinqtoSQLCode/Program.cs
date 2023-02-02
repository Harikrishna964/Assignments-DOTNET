using LinqtoSQLCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSQL
{
    internal class Program
    {
        static DataClasses1DataContext mdc = new DataClasses1DataContext();
        static void Main()
        {
            int option;
            char choice;
            do
            {
                Console.WriteLine("1. Select \n2. Insert \n3. Update \n4. Delete \n5. Exit");
                Console.Write("Enter your Choice: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        SelectEmployee();
                        break;
                    case 2:
                        InsertEmployee();
                        break;
                    case 3:
                        Console.WriteLine("Enter Emplyoee Id");
                        int empid = Convert.ToInt32(Console.ReadLine());
                        UpdateEmployee(empid);
                        break;
                    case 4:
                        Console.WriteLine("Enter Emplyoee Id");
                        int deleteid = Convert.ToInt32(Console.ReadLine());
                        DeleteEmployee(deleteid);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Do you want to continue (Y/N):");
                choice = Console.ReadLine()[0];
            } while (choice == 'y' || choice == 'Y');
        }

        static void SelectEmployee()
        {
            int selectoption;
            char selectchoice;
            do
            {
                Console.WriteLine("1. All Employees \n2. Based on Department \n3. Based on Salary \n4. Salary Stats ");
                Console.Write("Enter your Choice: ");
                selectoption = Convert.ToInt32(Console.ReadLine());
                switch (selectoption)
                {
                    case 1:
                        AllEmployees();
                        break;
                    case 2:
                        DepartmentBased();
                        break;
                    case 3:
                        SalaryBased();
                        break;
                    case 4:
                        SalaryStats();
                        break;

                }
                Console.WriteLine("\nDo you want to continue (Y/N):");
                selectchoice = Console.ReadLine()[0];
            } while (selectchoice == 'y' || selectchoice == 'Y');
        }
        static void InsertEmployee()
        {
            Employee emp = new Employee();
            Console.Write("Enter Employee Name: ");
            string Name = Console.ReadLine();
            emp.EmpName = Name;
            Console.Write("Enter Employee Salary: ");
            Decimal Sal = decimal.Parse(Console.ReadLine());
            emp.Salary = Sal;
            Console.Write("Enter Employee Department Name: ");
            byte deptid = byte.Parse(Console.ReadLine());
            emp.DeptId = deptid;
            mdc.Employees.InsertOnSubmit(emp);
            mdc.SubmitChanges();
        }
        static void UpdateEmployee(int empid)
        {
            Employee emp = new Employee();
            emp = mdc.Employees.Single(x => x.EmpId == empid);
            Console.WriteLine("Enter your update name:");
            string _name = Console.ReadLine();
            Console.WriteLine("Enter your update salary:");
            decimal _sal = decimal.Parse(Console.ReadLine());
            emp.EmpName = _name;
            emp.Salary = _sal;
            mdc.SubmitChanges();

        }
        static void DeleteEmployee(int empid)
        {
            Employee emp = new Employee();
            emp = mdc.Employees.Single(x => x.EmpId == empid);
            mdc.Employees.DeleteOnSubmit(emp);
            mdc.SubmitChanges();
        }
        static void DepartmentBased()
        {
            int deptbased;
            Console.Write("Enter Department ID: ");
            deptbased = Convert.ToInt32(Console.ReadLine());
            var EmployeeQuery = from emp in mdc.Employees where (emp.DeptId == deptbased) select emp;
            foreach (var emp in EmployeeQuery)
            {
                Console.WriteLine("ID\t\t= {0}", emp.EmpId);
                Console.WriteLine("Name\t\t= {0}", emp.EmpName);
                Console.WriteLine("Salary\t\t= {0}", emp.Salary);
                Console.WriteLine("Department\t= {0}", emp.DeptId);
                Console.WriteLine("----------------------------------------------");
            }
        }
        static void SalaryBased()
        {
            int salaryrange;
            Console.Write("Enter range of a salary: ");
            salaryrange = Convert.ToInt32(Console.ReadLine());
            var EmployeeQuery = from emp in mdc.Employees where emp.Salary < salaryrange select emp;
            foreach (var emp in EmployeeQuery)
            {
                Console.WriteLine("ID\t\t= {0}", emp.EmpId);
                Console.WriteLine("Name\t\t= {0}", emp.EmpName);
                Console.WriteLine("Salary\t\t= {0}", emp.Salary);
                Console.WriteLine("Department\t= {0}", emp.DeptId);
                Console.WriteLine("----------------------------------------------");
            }
        }
        static void SalaryStats()
        {
            decimal min, max, avg, total;
            var EmployeeQuery = from emp in mdc.Employees
                                join dep in mdc.Departments on emp.DeptId equals dep.DeptId
                                orderby emp.DeptId
                                group emp by dep.DeptName into g
                                select new
                                {
                                    s = g.Sum(x => x.Salary),
                                    m = g.Max(x => x.Salary),
                                    a = g.Average(x => x.Salary),
                                    d = g.Key

                                };

            foreach (var emp in EmployeeQuery)
            {

                Console.WriteLine("Department Name: {0}\t", emp.d);
                Console.Write("Sum={0}\n", emp.s);
                Console.Write("Max={0}\n", emp.m);
                Console.Write("Average={0}\n", emp.a);
                Console.WriteLine("\n-------------------");
                Console.WriteLine();
            }
        }
        static void AllEmployees()
        {
            var EmployeeQuery = from emp in mdc.Employees select emp;

            foreach (var emp in EmployeeQuery)
            {
                Console.WriteLine("ID\t\t= {0}", emp.EmpId);
                Console.WriteLine("Name\t\t= {0}", emp.EmpName);
                Console.WriteLine("Salary\t\t= {0}", emp.Salary);
                Console.WriteLine("Department\t= {0}", emp.DeptId);
                Console.WriteLine("----------------------------------------------");
            }
        }
    }
}
