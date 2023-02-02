using System;
delegate int mydel(int x);
delegate double mydel1(int y);
namespace DelegateProgram
{
    class Calculation
    {
        public static double Calc(mydel1 d)
        {
            return d(88);
        }
    }

    class DelegateImplementation
    {
        private static int Square(int x)
        {
            return x * x;
        }
        private static int Cube(int x)
        {
            return x * x * x;
        }
        private static double SquareRoot(int x)
        {
            return Math.Sqrt(x);
        }
        static void Main()
        {
            mydel d1 = new mydel(Square);
            d1 += Cube;
            /*foreach(mydel d in d1.GetInvocationList()){
                Console.WriteLine(d.Method);
                Console.WriteLine(d.DynamicInvoke(10));
            }*/
            Delegate[] delarr = d1.GetInvocationList();
            foreach (mydel d in delarr)
            {
                Console.WriteLine(d.Method);
                Console.WriteLine(d.DynamicInvoke(45));
            }
            mydel1 d2 = SquareRoot;
            Console.WriteLine(d2.Method);
            Console.WriteLine(d2.DynamicInvoke(25));
            Console.WriteLine(Calculation.Calc(SquareRoot));





        }
    }
}
