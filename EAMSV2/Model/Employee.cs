using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAMSV2.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }

        public string EMPId { get; set; }
        public string NID { get; set; }

        public DateTime DOB { get; set; }

        public string Address { get; set; }

        public string ContractNumber { get; set; }

        public double Salary { get; set; }

    }
}
