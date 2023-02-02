using System;
namespace EmployeeIcomparable

{
    class Employee : IComparable
    {
        public int Salary;
        public override string ToString()
        {
            return this.Salary.ToString();
        }
        public int CompareTo(object obj)
        {
            Employee e = (Employee)obj;
            return this.Salary.CompareTo(e.Salary);
        }
    }
    class GenericComparable<Hari>
    {

        public void SwapValues<Hari>(ref Hari a, ref Hari b)
        {
            Hari temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swap");
            Console.WriteLine("First Value: " + a);
            Console.WriteLine("Second Value: " + b);
            Console.WriteLine();
        }
    }  
    class MainClass
    {
        static GenericComparable<int> a = new GenericComparable<int>();
        static void Main()
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            e1.Salary = 500;
            e2.Salary = 1000;
            a.SwapValues<Employee>(ref e1, ref e2);
        }
    }
}
