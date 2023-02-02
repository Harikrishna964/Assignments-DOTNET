using System;
namespace StringLengthProgram
{
    class MainClass
    {
        static char[] Reverse(string s)
        {
            char[] c = s.ToCharArray();
            Array.Reverse(c);
            return c;
        }
        static void Main()
        {
            string str;
            Console.Write("Enter a string: ");
            str = Console.ReadLine();
            char[] temp = Reverse(str);
            Console.Write("Reverse Of the string: ");
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i]);
            }

        }
    }
}