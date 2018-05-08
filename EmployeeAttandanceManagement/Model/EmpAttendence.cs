using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttandanceManagement.Model
{
    public class EmpAttendence
    {
        public int AttendanceId { get; set; }

        public int EMPId { get; set; }

        public bool PresentAbsent { get; set; }

        public DateTime DateOfDay { get; set; }
    }
}
