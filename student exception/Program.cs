using System;
using ExceptionClassLibrary;
namespace StudentCustomException
{



    class Student
    {
        static int Id = 101;
        int _id;
        string _studentName;
        int marks;
        public Student(string studentName, int marks)
        {



            _id = Id++;
            this._studentName = studentName;
            this.marks = marks;

        }
        public string DisplayData()
        {
            return String.Format("Student ID {0}\n Student Name: {1}\n Marks: {2}", _id, _studentName, marks);



        }
        public int Student_RollNumber
        {
            get
            {
                return this._id;
            }



        }
    }
    class MainClass
    {

        static string studentName;
        static int marks;
        static Student[] s = new Student[10];
        static int count;
        static char ch;
        static Student s2;
        public static void AddStudent()
        {


            try
            {
                Console.Write("Enter the Student Name: ");
                studentName = Console.ReadLine();
                Console.WriteLine("Enter student Marks: ");
                marks = int.Parse(Console.ReadLine());
                if (marks > 100)
                {
                    throw new MarksOverException("Marks entered is above Maximum Marks!");
                }
                else if (marks < 0)
                {
                    throw new MarksOverException("Marks entered is Negative");
                }
                s[count++] = new Student(studentName, marks);
                Console.WriteLine("Student data added Successfully! Student Id: {0}", s[count - 1].Student_RollNumber);




            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static void SearchStudentResult()
        {
            Console.WriteLine("Enter the Roll Number");
            int rno = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                if (s[i].Student_RollNumber == rno)
                {
                    Console.WriteLine(s[i].DisplayData());
                }
            }
        }
        public static void PrintAllStudentsDetails()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(s[i].DisplayData());
                Console.WriteLine("-------------------------------------------");
            }
        }
        static void Main()
        {

            do
            {
                Console.WriteLine("1. Add Student\n2. Print Indivisual Student Marks\n3. Display All Student Details\n4. Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        SearchStudentResult();
                        break;
                    case 3:
                        PrintAllStudentsDetails();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter a valid option");
                        break;
                }
                Console.Write("Do you want to continue(Y|N)");
                ch = Console.ReadLine()[0];
            } while (ch == 'Y' || ch == 'y');
        }



    }
}

    namespace ExceptionClassLibrary
    {
        public class MarksOverException : Exception
        {
            public MarksOverException(string message) : base(message) { }



            public MarksOverException(string message, Exception innerException) : base(message, innerException) { }
            public MarksOverException() : base() { }
        }
        public class MarksNegativeException : Exception
        {
            public MarksNegativeException(string message) : base(message) { }



            public MarksNegativeException(string message, Exception innerException) : base(message, innerException) { }
            public MarksNegativeException() : base() { }
        }
    }

