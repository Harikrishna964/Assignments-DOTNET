using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesForm
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void btnDelete_Click (object sender, EventArgs e)
        {
            SqlConnection objConn;
            SqlCommand objCmd;
            IDataReader dr;
            string strCmd;

            Data Source = @"Data Source=PRSQL;Initial Catalog=Employee;Persist Security Info=True;User ID=labuser;Password=Welcome123$";
            public EmployeeForm()
            {
                InitializeComponent();
                objConn = new SqlConnection();
                objCmd = new SqlCommand();
                objCmd.Connection = objConn;
            }



        }
    }
}
