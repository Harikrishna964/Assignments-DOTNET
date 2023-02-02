using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;



namespace GarbageCollection
{
    class MainClass
    {
        static void Main()
        {
            using (Employee e1 = new Employee(1, "Hari"))
            {

                e1.Salary = 1000;
                e1.WorkStatus();
                e1.IncrementSalary(5000);

            }
            using (Employee e2 = new Employee(2, "Krishna"))
            {
                e2.Salary = 15000;
                e2.WorkStatus();
                e2.IncrementSalary(5000);
            }
            //e1.Dispose();
            Console.WriteLine("-------------------------");
            //e1.Salary = 100;



        }
    }
}
