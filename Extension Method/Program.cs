using System;
namespace ExtensionMethod
{
    public static class MyExtensions
    {
        public static int ToInt32(this string s)
        {
            return int.Parse(s);
        }
    }
    class Mainclass
    {
        static void Main()
        {
            string str = "964007";
            int i = str.ToInt32();
            Console.WriteLine(i);
        }
    }
}
