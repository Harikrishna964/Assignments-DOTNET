using System;
using System.Collections;
namespace EmployeeGeneric
{
    class Employeeclass
    {
        public readonly int _empId;
        public readonly string _empName;
        static int empid;
        public Employeeclass(string empname)
        {
            _empId = empid++;
            this._empName = empname;
        }
        public override string ToString()
        {
            return string.Format("Employee Id:{0}\n Employee Name:{1} ", _empId, _empName);
        }
        public int EmployeeId
        {
            get { return _empId; }
        }

    }
    class MainClass
    {
        static Employeeclass[] emp = new Employeeclass[10];
        static ArrayList emparraylist = new ArrayList();
        static SortedList empsortedlist = new SortedList();
        static List<Employeeclass> emplist = new List<Employeeclass>();
        static Hashtable empHashtable = new Hashtable();
        static char ch;
        static int counter = 0;
        static void Main()
        {
            emparraylist.Add(new Employeeclass("Hari"));
            emparraylist.Add(new Employeeclass("Krishna"));
            emparraylist.Add(new Employeeclass("Gajula"));
            emparraylist.Add(new Employeeclass("Ranjini"));
            emparraylist.Add(new Employeeclass("Naveen"));



            foreach (object o in emparraylist)
            {
                Console.WriteLine(o);
            }



            Console.WriteLine();



            emplist.Add(new Employeeclass("Hari"));
            emplist.Add(new Employeeclass("Krish"));
            emplist.Add(new Employeeclass("Sumith"));
            emplist.Add(new Employeeclass("Bhushanam"));



            foreach (object o in emplist)
            {
                Console.WriteLine(o);
            }

                Console.WriteLine();

            do
            {
                Console.WriteLine("1. Add Employee\n2.Print Employees Salary Slip\n3. Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Write("Enter Employee Username: ");
                        string name = Console.ReadLine();

                        emp[counter++] = new Employeeclass(name);
                        break;
                    case 2:
                        for (int i = 0; i < counter; i++)
                        {
                            Console.WriteLine(emp[i]);
                            Console.WriteLine("*****************************");
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please Enter a valid option");
                        break;
                }
                Console.WriteLine("Do you want to continue(Y|N)");
                ch = Console.ReadLine()[0];
            } while (ch == 'Y' || ch == 'y');



            for (int i = 5; i < counter; i++)
            {
                empHashtable.Add(emp[i].EmployeeId, emp[i]._empName);



            }
            Console.WriteLine();
            foreach (object o in empHashtable.Values)
            {
                Console.WriteLine(o);
            }

            Array.Reverse(emp);
            foreach (object o in emp)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine();

            for (int i = 5; i < counter; i++)
            {
                empsortedlist.Add(emp[i].EmployeeId, emp[i]._empName);

            }
            foreach (object o in empsortedlist.Values)
            {
                Console.WriteLine(o);
            }

        }

    }
}
