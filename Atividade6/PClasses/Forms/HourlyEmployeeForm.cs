using PClasses.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses.Forms
{
    public partial class HourlyEmployeeForm : Form
    {
        public HourlyEmployeeForm()
        {
            InitializeComponent();
        }

        // Buttons

        private void ButtonInstantiate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.textBoxId.Text);
                string name = this.textBoxName.Text;
                DateTime companyEntryDate = DateTime.Parse(this.textBoxCompanyEntryDate.Text);
                double hourlySalary = double.Parse(this.textBoxHourlySalary.Text);
                double workingHours = double.Parse(this.textBoxWorkingHours.Text);
                int absentDays = int.Parse(this.textBoxAbsentDays.Text);

                // var hourlyEmployee = new HourlyEmployee(id, name, companyEntryDate, hourlySalary, workingHours, absentDays);

                HourlyEmployee hourlyEmployee = new HourlyEmployee();

                // Set

                hourlyEmployee.Id = id;
                hourlyEmployee.Name = name;
                hourlyEmployee.CompanyEntryDate = companyEntryDate;
                hourlyEmployee.HourlySalary = hourlySalary;
                hourlyEmployee.WorkingHours = workingHours;
                hourlyEmployee.AbsentDays = absentDays;

                // Get

                MessageBox.Show(
                    $"Id = {hourlyEmployee.Id}\n" +
                    $"Nome = {hourlyEmployee.Name}\n" +
                    $"Tempo Trabalho = {hourlyEmployee.WorkingTimeInDays()} dias\n" +
                    $"Salário = R$ {hourlyEmployee.GrossSalary().ToString("N2")}"
                );
            }
            catch (Exception)
            {
                MessageBox.Show("Inputs inválidos!");
            }
        }
    }
}
