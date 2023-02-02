using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

 

namespace MVCDataLayerStart.ViewModels
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int Salary { get; set; }
        public string SalaryColor { get; set; }
    }
}