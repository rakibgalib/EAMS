using EAMSV2.Manger;
using EAMSV2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAMSV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EmployeeManger EmpManager = new EmployeeManger();
        private void saveButton_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmpName = employeeNameTextBox.Text;
            emp.EMPId = IncrementID("BS");
            emp.NID = nidTextBox.Text;
            emp.DOB = dobDateTimePicker.Value;
            emp.Address = addressTextBox.Text;
            emp.ContractNumber = contactNumberTextBox.Text;
            emp.Salary =Convert.ToDouble(salaryTextBox.Text);
            string message= EmpManager.SaveEmployee(emp);
            MessageBox.Show(message);


            
        }

        static string IncrementID(string startValue)
        {
            string text = startValue.Substring(0, 1);
            string numbers = startValue.Substring(1);
            int n;
            Int32.TryParse(numbers, out n);
            n++;
            return text + n.ToString().PadLeft(numbers.Length, '0');
        }
    }
}
