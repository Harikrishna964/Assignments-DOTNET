using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LinqToProgram

{
    internal class Program
    {
        public static object CommandType { get; private set; }

        static void TwoTableQuery()
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            string strConn = @"Data Source=PRSQL;Initial Catalog=Employee;Persist Security Info=True;User ID=labuser;Password=Welcome123$";
            string strCmd = "Select CustomerID,ContactName,City From Customers";
            objConn.ConnectionString = strConn;
            objCmd.Connection = objConn;
            objCmd.CommandType = CommandType.Text;
            objCmd.CommandText = strCmd;
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = objCmd;
            da.Fill(ds, "Customer");
            DataTable Customers = ds.Tables["Customer"];

            strCmd = "Select OrderID,CustomerID,OrderDate From Orders";
            objCmd.CommandText= strCmd;
            da.Fill(ds, "Order");
            DataTable Orders = ds.Tables["Order"];

            var query =
                from order in Orders.AsEnumerable()
                join Customer in Customers.AsEnumerable()
                on order.Field<string>("CustomerID") equals
                Customer.Field<string>("CustomerID")
                orderby Customer.Field<string>("CustomerID")
                select new
                {
                    CustomerID = Customer.Field<string>("CustomerID"),
                    CustomerName = Customer.Field<string>("ContactName"),
                    OrderID = order.Field<int>("OrderID"),
                    OrderDate = order.Field<DataTime>("OrderDate")
                };
            foreach (var data in query)
            {
                Console.WriteLine("Customer ID={0}", data.CustomerID);
                Console.WriteLine("Customer Name={0}", data.CustomerName);
                Console.WriteLine("Order ID={0}", data.OrderID);
                Console.WriteLine("Order Date={0}", data.OrderDate);
            }
            
        }
    }
}
