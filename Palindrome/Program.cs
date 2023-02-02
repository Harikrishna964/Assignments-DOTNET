using System;

namespace Palindrome
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            int n, rem, sum = 0, temp;

            Console.WriteLine(" Enter a number ");
            n = int.Parse(Console.ReadLine());
            temp = n;

            while (n > 0)
            {
                rem = n % 10;
                sum = (sum * 10) + rem;
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine(" Palindrome Number");

            }
            else
            {
                Console.WriteLine(" Not a Palindrome Number ");
            }
        }
    }
}