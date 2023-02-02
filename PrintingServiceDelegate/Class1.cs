using System;
namespace PrintingServiceDelegate
{
    public class PrintingService
    {
        public static void Print(PrintDelegate d)
        {
            d();
        }
    }
}