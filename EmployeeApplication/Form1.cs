using EmployeeNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnComputeSalary_Click(object sender, EventArgs e)
        {
           
            PartTimeEmployee employee = new PartTimeEmployee();

            
            employee.Name = TextFirstName.Text;
            employee.LastName = TextLastName.Text; 
            employee.JobTitle = TextJobTitle.Text; 
            employee.RatePerHour = Convert.ToDouble(TextRatePerHour.Text);
            employee.HoursWorked = Convert.ToDouble(TextHoursWorked.Text);

            
            double salary = employee.CalculateSalary();

            
            lblResult.Text = $"FirstName: {employee.Name}\n" +
                $"\nLastName {employee.LastName}\n" +
                $"\nbasic Salary: {salary:C}";
        }

        private void TextHoursWorked_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
