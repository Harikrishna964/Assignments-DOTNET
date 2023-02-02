using System;
using CustomerDelegate;
using ProductDelegate;
using EmployeeDelegate;



namespace MainClassProgram
{
    class MainClass
    {
        static void Main()
        {
            Customer cust = new Customer(101, "Hari");
            Product prod = new Product(1, "Krishna");
            Employee emp = new Employee(200, "Gajula", 1200, 23, 90);
            cust.AvailService();
            Console.WriteLine("-----------------------------------");
            prod.UseService();
            Console.WriteLine("------------------------------------");
            emp.GenerateSalarySlip();
            Console.WriteLine("-------------------------------------");
        }
    }
}