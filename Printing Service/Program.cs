namespace PrinterLibrary
{
    public class PrintingService
    {
        public static void Print(PrintDelegate d)
        {
            d();
        }
    }

  
}
