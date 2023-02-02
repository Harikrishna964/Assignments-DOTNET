using System;
namespace StudentMarks
{
    class Student
    {
        int _roll_no, _sem, _class;
        string _studentName, _branch;
        int[] marks = new int[5];



        public double CalculateAverage()
        {
            double Avg;
            int sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }
            Avg = sum / marks.Length;
            return Avg;
        }
        public string DisplayResult()
        {
            double avg = CalculateAverage();
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < 35)
                {
                    return string.Format("Failed");

                }
            }
            if (avg < 50)
            {
                return string.Format("Failed");
            }
            else
            {
                return string.Format("Congratulations! Passed");
            }
        }
        public Student(int roll_no, string studentName, int sem, string branch, int[] marks)
        {
            _roll_no = roll_no;
            _sem = sem;
            _studentName = studentName;
            _branch = branch;
            this.marks = marks;
        }
        public void DisplayData()
        {
            Console.WriteLine("Student Roll Number: {0}\n Student Name: {1}\n Sem: {2}\n Branch: {3}\n ", _roll_no, _studentName, _sem, _branch);
            Console.WriteLine("Marks of 5 subjects: ");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
            Console.WriteLine("Result: ");
            Console.WriteLine(DisplayResult());



        }
        public int Student_RollNumber
        {
            get
            {
                return _roll_no;
            }
        }
    }

    class MainClass
    {
        static int roll_no, sem, studentclass;
        static string studentName, branch;
        static int[] marks = new int[5];
        static Student[] s = new Student[10];
        static int count;
        static char ch;
        public static void AddStudent()
        {
            Console.Write("Enter the Student Roll Number: ");
            roll_no = int.Parse(Console.ReadLine());
            Console.Write("Enter the Student Name: ");
            studentName = Console.ReadLine();
            Console.WriteLine("Enter Sem: ");
            sem = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Branch");
            branch = Console.ReadLine();
            Console.WriteLine("Enter Class: ");
            studentclass = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks of 5 Subjects: ");
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
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
                    Console.WriteLine(s[i].DisplayResult());
                }
            }
        }
        public static void PrintAllStudentsDetails()
        {
            for (int i = 0; i < count; i++)
            {
                s[i].DisplayData();
                Console.WriteLine("-------------------------------------------");
            }
        }
        static void Main()
        {
            do
            {
                Console.WriteLine("1. Add Student\n2. Print Result\n3. Display All Student Details\n4. Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddStudent();
                        s[count++] = new Student(roll_no, studentName, sem, branch, marks);
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