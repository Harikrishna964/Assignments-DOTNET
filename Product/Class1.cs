using System;
namespace ProductProgram
{
    class Product
    {
        int probID;
        string probName;
        public Product(int id, string name)
        {
            this.probID = id;
            this.probName = name;
        }
        public void DisplayproductDetails()
        {
            Console.WriteLine("Product ID: {0}", this.probID);
            Console.WriteLine("Product Name: {0}", this.probName);
        }
        public void UseService()
        {
            PrintDelegate d = new PrintDelegate(DisplayProductDetails);
            PrintingService.Print(d);
        }
    }
}
