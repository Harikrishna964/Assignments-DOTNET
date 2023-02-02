using System;
using PrintingServiceDelegate;
namespace CustomerDelegate



{
    public class Customer
    {
        int _customerId;



        string _customerName;



        public Customer(int custId, string custName)
        {
            _customerId = custId;
            _customerName = custName;
        }



        public void Display()
        {
            Console.WriteLine(" Emp Id: {0}", _customerId);
            Console.WriteLine(" Emp Name: {0}", _customerName);
        }
        public void AvailService()
        {
            PrintingService.Print(Display);
        }
    }



}