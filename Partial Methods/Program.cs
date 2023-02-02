using System;
namespace PartialMethod
{
    class Mainclass
    {
        static void Main()
        {
            MyPartialclass p = new MyPartialclass();
            p.CallNonStaticMethod();            
            MyPartialClass.CallStaticMethod();

        }
    }
}
