using System;
namespace Customer
{
    class customer
    {
        int custID;
        string custName;
        public Customer(int id, string name)
        {
            this.custID = id;
            this.custName = name;

        }
        private void Display()
        {
            Console.WriteLine("Cust ID:{0}", this.custID);
            Console.WriteLine("Cust Name:{0}", this.custName);

        }
        public void AvailService()
        {
            printDelegate d new printDelegate(Display);
            printingService.Print(d);
        }
    }
}
