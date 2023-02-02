using System;
namespace Deligate
{
    class Mainclass
    {
        static void Main()
        {
            Customer cust = new Customer(101, "Hari");
            product prob = new product(111, "Krishna");
            Employee emp = new Employee(2022, "Hari", 10000, 12000, 5000);
            cust.AvailService();
            Console.WriteLine("------------------");
            prod.UseService();
            Console.WriteLine("-------------------");
            emp.GenerateSalarySlip();
        }
    }
}
