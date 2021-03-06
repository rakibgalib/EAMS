﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAMSV2.Gateway;
using EAMSV2.Model;
namespace EAMSV2.Manger
{
    public class EmployeeManger
    {
        EmployeeGateway empGateway = new EmployeeGateway();

        public string SaveEmployee(Employee emp)
        {
            if (empGateway.IsEmployeeExistes(emp.EmpName))
            {
                return "Employee already exist";
            }
            else
            {
                int rowAffect = empGateway.SaveEmployee(emp);
                if (rowAffect > 0)
                {
                    return "Save Successfully";
                }
                return "Save falied";
            }
        }

        public List<Employee> GetAllEmployee()
        {
            return empGateway.GetAllEmployee();
        }
    }
}
