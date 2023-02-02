using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC_DataLayerStart.Models
{
        public class EmployeeBusinessLayer
        {
            Mycompanycontext saleDal;
            public EmployeeBusinessLayer()
            {
                saleDal = new Mycompanycontext();
            }
            public List<Employee> GetEmployee()
            {
                return saleDal.Employees.ToList();
            }





            public Employee SaveEmployee(Employee e)
            {
                saleDal.Employees.Add(e);
                saleDal.SaveChanges();
                return e;
            }
            public Boolean IsValidUser(UserDetails u)
            {
                if (u.UserName == "Hari" && u.Password == "1234")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }





        }
    }
   