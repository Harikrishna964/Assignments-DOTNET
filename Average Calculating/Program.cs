using System;

namespace AverageCalculating
{

    class Mainclass
    {
        public static double Average(double n1, double n2, double n3)
        {
            double avrg = (n1 + n2 + n3) / 3;
            return avrg;
        }
        static void Main(string[] args)
        {
            double sub1, sub2, sub3;
            double avg;
            Console.Write(" Enter Biology Marks ");
            sub1 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Enter Physics Marks ");
            sub2 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Enter Chemistry Marks ");
            sub3 = Convert.ToDouble(Console.ReadLine());
            avg = Average(sub1, sub2, sub3);
            Console.WriteLine("The average of three numbers is " + avg);
            Console.ReadKey();
        }
    }
}