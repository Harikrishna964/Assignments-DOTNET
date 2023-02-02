using System;

namespace Largestandsmallest
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, largest;
            Console.WriteLine("Enter First Number ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Second Number");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Third Number");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
                largest = n1;
            else if (n2 > n3 && n2 > n1)
                largest = n2;
            else
                largest = n3;
            Console.WriteLine("Largest among {0}, {1} & {2} is {3} ", n1, n2, n3, largest);
        }
    }
}

