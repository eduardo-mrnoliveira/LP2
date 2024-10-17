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
    public partial class SalariedEmployeeForm : Form
    {
        public SalariedEmployeeForm()
        {
            InitializeComponent();
        }

        // Botões

        private void ButtonInstantiate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.textBoxId.Text);
                string name = this.textBoxName.Text;
                DateTime companyEntryDate = DateTime.Parse(this.textBoxCompanyEntryDate.Text);
                double monthlySalary = double.Parse(this.textBoxMonthlySalary.Text);

                // var salariedEmployee = new SalariedEmployee(id, name, companyEntryDate, monthlySalary);

                SalariedEmployee salariedEmployee = new SalariedEmployee();

                // Set
                
                salariedEmployee.Id = id;
                salariedEmployee.Name = name;
                salariedEmployee.CompanyEntryDate = companyEntryDate;
                salariedEmployee.MonthlySalary = monthlySalary;

                // Get

                MessageBox.Show(
                    $"Id = {salariedEmployee.Id}\n" +
                    $"Nome = {salariedEmployee.Name}\n" +
                    $"Tempo Trabalho = {salariedEmployee.WorkingTimeInDays()} dias\n" +
                    $"Salário = R$ {salariedEmployee.GrossSalary().ToString("N2")}"
                );
            }
            catch (Exception)
            {
                MessageBox.Show("Inputs inválidos!");
            }
        }
    }
}
