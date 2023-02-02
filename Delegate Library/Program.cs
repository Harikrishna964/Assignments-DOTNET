using DelegateLibrary;
namespace StudentLibrary
{
    public class Student
    {
        int studentID;
        string studentName;
        public Student(int id, string name)
        {
            this.studentID = id;
            this.studentName = name;
        }
        private void Display()
        {
            Console.WriteLine("student ID:{0}", this.studentID);
            Console.WriteLine("student Name:{0}", this.studentName);
        }
        public void StudentDetails()
        {
            PrintingService.Print(Display);
        }
    }
}
