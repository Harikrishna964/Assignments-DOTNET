using System;
namespace Employee
{
    class Employee
    {
        int empID;
        string empName;
        int basic, da, hra;
        public Employee(int id, string name, int basic, int da, int hra)
        {
            this.empID = id;
            this.empName = name;
            this.basic = basic;
            this.da = da;
            this.hra = hra;

        }
        private int salary
        {
            get
            {
                return basic + da + hra;
            }
        }

        public object PrintingService { get; private set; }

        private void salarySlip()
        {
            Console.WriteLine("Emp ID: {0}", this.empID);
            Console.WriteLine("Emp Name: {0}", this.empName);
            Console.WriteLine("Salary {0}", salary);

        }
        public void GenerateSalary()
        {
            PrintingService.print(SalarySlip);
        }

    }
}

