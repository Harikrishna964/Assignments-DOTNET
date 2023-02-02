using System;

namespace Odd_Even
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            int number, remainder;
            Console.WriteLine(" Enter integer Value");
            number = Convert.ToInt32(Console.ReadLine());

            remainder = number % 2;
            if (remainder == 0)
                Console.WriteLine(" It is Even Number");
            else
                Console.WriteLine(" It is Odd Number");
        }
    }

}
