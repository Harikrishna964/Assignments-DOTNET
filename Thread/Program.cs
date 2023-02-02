using System;
using System.Threading;
namespace ThreadingProgram
{
    class MainClass
    {
        static void M()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(" Thread M:{0} ", i + 1);
            }
        }
        static void N()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(" Thread N:{0} ", i + 1);
            }
        }
        static void P1(object o)
        {
            Console.WriteLine("Hello " + (string)o);
        }
        static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(M));
            Thread t2 = new Thread(N);
            t1.Start();
            t2.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" Main class Thread:{0} ", i + 1);
            }
            Thread t3 = new Thread(new ParameterizedThreadStart(P1));
            t3.Start("Hari");
            Console.WriteLine("End of MainClass");
            Console.WriteLine("---------------------------------");



        }
    }
}
