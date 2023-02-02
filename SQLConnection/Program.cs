using System;
using System.Data;
using System.Data.SqlClient;



namespace SqlConnTest
{
   class MainClass
    {
        static void Connected()
        {
            string strConn = @"Data Source=PRSQL;Initial Catalog=Employee;Persist Security Info=True;User ID=labuser;Password=Welcome123$";
            SqlConnection objConn = new SqlConnection();
            objConn.ConnectionString = strConn;

            SqlCommand objCmd = new SqlCommand();
            string strCmb = @"Select * From EmployeeTable";
            objCmd.Connection = objConn;
            objCmd.CommandType = CommandType.Text;
            objCmd.CommandText = strCmb;

            SqlDataReader reader;
            objConn.Open();
            reader = objCmd.ExecuteReader();
            Console.Write("ID");
            Console.Write("\tName");
            Console.Write("\t Salary");
            Console.WriteLine("\t DeptID");
            Console.WriteLine("--------------------------");
            while(reader.Read())
            {
                Console.WriteLine(reader[0]);
                Console.WriteLine("\t" + reader["Emp_Name"]);
                Console.WriteLine(reader["Salary"]);
                Console.WriteLine("\t" + reader["Dept_ID"]);
            }
            reader.Close();
            objConn.Close();
        }
        static void Disconnected()
        {
            string strConn = @"Data Source=PRSQL;Initial Catalog=Employee;Persist Security Info=True;User ID=labuser;Password=Welcome123$";
            SqlConnection objConn = new SqlConnection();
            objConn.ConnectionString=strConn;

            SqlCommand objCmd = new SqlCommand();
            string strcmd = @"Select * From Employees";
            objCmd.Connection=objConn;
            objCmd.CommandType = CommandType.Text;
            objCmd.CommandText=strcmd;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = objCmd;
            DataSet ds = new DataSet();
            adapter.Fill(ds,
                    "MyEmployees");

            DataTable empTable = ds.Tables["MyEmployees"];

            Console.Write("ID");
            Console.Write("\tName");
            Console.Write("\t Salary");
            Console.WriteLine("\t DeptID");
            Console.WriteLine("--------------------------");
            foreach(DataRow row in empTable.Rows)
            {
                Console.WriteLine(row[0]);
                Console.WriteLine("\t" + row["Emp_Name"]);
                Console.WriteLine(row["Salary"]);
                Console.WriteLine("\t" + row["Dept_ID"]);
            }

        }

        static void Main()
        {
            /* string strconn = @"Data Source=PRSQL;Initial Catalog=Employee;Persist Security Info=True;User ID=labuser;Password=Welcome123$";
             SqlConnection connobject = new SqlConnection(strconn);
             connobject.Open();
             Console.WriteLine("hello Hari");
             connobject.Close();*/
            Connected();

        }
    }
}


