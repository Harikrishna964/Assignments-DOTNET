using System;
using System.Collections.Generic;



public class Employee : IComparable
{



    public int ID;
    public string EmployeeName;



    public Employee(int id, string employeename)
    {
        this.ID = id;
        this.EmployeeName = employeename;
    }



    public int CompareTo(object incomingobject)
    {




        Employee incomingemployee = incomingobject as Employee;



        return this.ID.CompareTo(incomingemployee.ID);
    }
}
class Mainclass
{



    static public void Main()
    {




        Employee[] employees = new Employee[]
        {
        new Employee(101, "Hari"),
        new Employee(501, "Krishna"),
        new Employee(301, "Naveen"),
        new Employee(211, "Mukesh"),
        new Employee(45, "Ranjini")
        };



        Console.WriteLine("Before sorting employees array");
        foreach (var emp in employees)
        {
            Console.WriteLine("ID - {0}, Employee Name - {1}",
                              emp.ID, emp.EmployeeName);
        }




        Array.Sort(employees);



        Console.WriteLine();



        Console.WriteLine("After sorting employees array");
        foreach (var emp in employees)
        {
            Console.WriteLine("ID - {0}, Employee Name - {1}",
                              emp.ID, emp.EmployeeName);
        }
    }
}


