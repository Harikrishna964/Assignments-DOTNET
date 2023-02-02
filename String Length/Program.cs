using System;
namespace StringLengthProgram
{
    class MainClass
    {
        static void Main()
        {
            string str;
            Console.Write("Enter a string: ");
            str = Console.ReadLine();
            Console.WriteLine("Length of the String is: {0}", str.Length);
        }
    }
}