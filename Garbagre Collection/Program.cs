using System;
namespace GarbageCollection
{
    class Employee:IDisposable
    {
        private bool isdisposed;
        private int id;
        private int salary;
        public int Salary;


        public Employee(int id)
        {
            this.id = id;
            this.isdisposed = false;
            Console.WriteLine("Object Instantiated for id={0}", this.id);
        }

    
        ~Employee()
        {
            if(! isdisposed )
            {
                this.Dispose();
            }
            Console.WriteLine("Object Destroyed for id={0}", this.id);
        }
        public void WorkStatus()
        {
            if(this.isdisposed)
            {
                throw new ObjectDisposedException(this.id.ToString(), "Employee has been Terminated");
            }
            else
            {
                Console.WriteLine("id=" + this.id + "is Working Properly");
            }
        }
        public void IncrementSalary(int increment)
        {
            if(this.isdisposed)
            {
                throw new ObjectDisposedException(this.id.ToString(), "Employee has been Terminated");
            }
            else
            {
                Console.WriteLine("Salary Incremented for Employee id={0}", this.id);
                this.salary += increment;
            }
        }
        public void Dispose()
        {
            Console.WriteLine(this.id + " is being Disposed ");
            GC.SuppressFinalize(this);
            this.isdisposed = true;
        }


    }
}

