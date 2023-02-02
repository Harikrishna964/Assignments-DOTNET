using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TypeDateset
{
    public partial class Form1 : Form
    {
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
            string strConn = @"Data Source=PRSQL;Initial Catalog=Employee;Persist Security Info=True;User ID=labuser;Password=Welcome123$";
            objConn = new SqlConnection(strConn);
            string strCmdSelect = @"Select * from Employees";
            objCmd = new SqlCommand(strCmdSelect, objConn);

            da = new SqlDataAdapter();
            da.SelectCommand = objCmd;
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
            ds = new DataSet();

        }

        

    }
}
