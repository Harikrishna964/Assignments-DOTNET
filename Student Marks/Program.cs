using System;
using System.Collections.Generic;
namespace Marks
{
    class MainClass
    {
        public static void MarksOperations(int[] marksarr)
        {
            double avg;
            int sum = 0;
            int max = marksarr[0], min = marksarr[0];
            for (int i = 0; i < marksarr.Length; i++)
            {
                sum += marksarr[i];
                if (marksarr[i] > max)
                {
                    max = marksarr[i];
                }
                if (marksarr[i] < min)
                {
                    min = marksarr[i];
                }
            }
            avg = sum / marksarr.Length;
            Console.WriteLine("Total Marks: " + sum);
            Console.WriteLine("Average Marks: " + avg);
            Console.WriteLine("Maximum Marks: " + max);
            Console.WriteLine("Minimun Marks: " + min);
            Array.Sort(marksarr);
            Console.WriteLine("Marks in Ascending Order: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(marksarr[i] + " ");
            }
            Console.WriteLine();
            Array.Reverse(marksarr);
            Console.WriteLine("Marks in Descending Order: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(marksarr[i] + " ");
            }
        }
        static void Main()
        {
            int[] _marksArray = new int[10];
            Console.WriteLine("Enter Marks of ten Students: ");
            for (int i = 0; i < 10; i++)
            {
                _marksArray[i] = int.Parse(Console.ReadLine());
            }
            MarksOperations(_marksArray);
        }


    }
}
