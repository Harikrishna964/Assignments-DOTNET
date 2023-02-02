using System;
using System.Runtime.Serialization.Formatters.Binary;
namespace Serializationcode

{
    [Serializable]
    class student
    {
        public readonly int ID;
        static int id = 100;
        public student()
        {
            this.ID = ++id;   

        }
    }
    class Mainclass
    {
        static void BinarySerialization(List<student>myList)
        {
            BinaryFormatter binformatter = new BinaryFormatter();
            FileStream fs = new FileStream("F:\\Student.txt", FileMode.OpenOrCreate, FileAccess.Write);
            binformatter.Serialize(fs, myList);
            fs.Close();
        }
        static void BinaryDeSerialization()
        {
            List<student> students;
            try
            {
                BinaryFormatter binFormatter = new BinaryFormatter();
                FileStream fs = new FileStream("F:\\Students.txt", FileMode.Open, FileAccess.Read );
                students = (List<student>)binFormatter.Deserialize(fs);

                foreach (student student in students)
                {
                    Console.WriteLine(student.ID);
                }
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main()
        {
            List<student> students = new List<student>();
            students.Add(new student());
            students.Add(new student());
            students.Add(new student());
            students.Add(new student());

            BinarySerialization(students);
            BinaryDeSerialization();
        }
    }
}