using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EmployeeAttandanceManagement.Model;
namespace EmployeeAttandanceManagement.Gateway
{
    class EmployeeGateway:Gateway
    {

        public int SaveEmployee(Employee emp)
        {
            Query = "Insert Into EmployeeInfo(EmpName,IdNo,NID,DOB,Address,ContactNumber,Salary) Values('" + emp.EmpName + "','" + emp.EMPId + "','" + emp.NID + "','" + emp.DOB + "','" + emp.Address + "','" + emp.ContractNumber + "','" + emp.Salary + "')";

            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffect;

        }

        public bool IsEmployeeExistes(string EmployeeName)
        {
            Query = "SELECT * FROM EmployeeInfo WHERE EmpName = '" +EmployeeName + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            bool isExist = Reader.HasRows;
            Reader.Close();
            Connection.Close();
            return isExist;
        }

        public List<Employee> GetAllEmployee()
        {
            Query = "SELECT * FROM EmployeeInfo";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Employee> employees = new List<Employee>();

            while (Reader.Read())
            {
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(Reader["Id"]);
                emp.EmpName = Reader["EmpName"].ToString();
                emp.EMPId = Reader["IdNo"].ToString();
                emp.DOB =Convert.ToDateTime( Reader["DOB"]);
                emp.Address = Reader["Address"].ToString();
                emp.ContractNumber= Reader["ContactNumber"].ToString();
                emp.Salary =Convert.ToDouble(Reader["Salary"]);

                employees.Add(emp);
            }
            Reader.Close();
            Connection.Close();
            return employees;
        }
    }
}
