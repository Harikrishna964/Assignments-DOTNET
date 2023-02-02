using System;

namespace Handlingprogram

{
    class DivNumbers
    {
        int value;


        DivNumbers()
        {
            value = 0;
        }
        public void division(int n1, int n2)
        {
            try
            {
                value = n1 / n2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", value);
            }
        }
        static void Main()
        {
            DivNumbers d = new DivNumbers();
            d.division(25, 0);
            Console.ReadKey();
        }
    }
}

