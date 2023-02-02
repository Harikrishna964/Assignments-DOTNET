using System;
namespace DuplicateString
{
    class MainClass
    {
        static void Main()
        {
            string str1, str2;
            Console.Write("Enter the first string: ");
            str1 = Console.ReadLine();
            Console.Write("Enter Second string: ");
            str2 = Console.ReadLine();
            if (str1 == str2)
            {
                Console.WriteLine("Both Strings are same!");
            }
            else
            {
                Console.WriteLine("Different Strings");
            }
        }
    }
}
