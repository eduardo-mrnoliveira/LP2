using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade.Forms
{
    public partial class Exercise4Form : Form
    {
        public Exercise4Form()
        {
            InitializeComponent();
        }

        // Inicialização

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.errorProvider.SetIconPadding(this.textBoxId, -16);
            this.errorProvider.SetIconPadding(this.textBoxName, -16);
            this.errorProvider.SetIconPadding(this.textBoxProduction, -16);
            this.errorProvider.SetIconPadding(this.textBoxBaseSalary, -16);
            this.errorProvider.SetIconPadding(this.textBoxGratification, -16);

            this.toolTip.SetToolTip(this.buttonCalculate, "Calcular o salário bruto.");
        }

        // Métodos

        private bool ValidateId(TextBox textBox, out int value)
        {
            bool isInt = int.TryParse(textBox.Text, out value);

            if (!isInt)
            {
                this.errorProvider.SetError(textBox, "Valor inválido!");

                return false;
            }

            if (value <= 0)
            {
                this.errorProvider.SetError(textBox, "Valor deve ser maior do que zero!");

                return false;
            }

            this.errorProvider.SetError(textBox, "");

            return true;
        }

        private bool ValidateName(TextBox textBox)
        {
            string text = textBox.Text;

            if (text == "")
            {
                this.errorProvider.SetError(textBox, "Valor não pode estar vazio!");

                return false;
            }

            this.errorProvider.SetError(textBox, "");

            return true;
        }

        private bool ValidateCurrency(TextBox textBox, out double value)
        {
            bool isDouble = double.TryParse(textBox.Text, out value);

            if (!isDouble)
            {
                this.errorProvider.SetError(textBox, "Valor inválido!");

                return false;
            }

            if (value < 0) // Allows zero
            {
                this.errorProvider.SetError(textBox, "Valor deve ser maior ou igual a zero!");

                return false;
            }

            this.errorProvider.SetError(textBox, "");

            return true;
        }

        private double CalculateSalaryWithBonuses(double baseSalary, double gratification, bool a = false, bool b = false, bool c = false)
        {
            double bonus = baseSalary * (
                0.05 * (a ? 1 : 0) +
                0.1 * (b ? 1 : 0) +
                0.1 * (c ? 1 : 0)
            );

            return baseSalary + bonus + gratification;
        }

        // Eventos

        private void TextBoxName_Validating(object sender, CancelEventArgs e)
        {
            this.ValidateName((TextBox)sender);
        }

        private void TextBoxId_Validating(object sender, CancelEventArgs e)
        {
            this.ValidateId((TextBox)sender, out _);
        }

        private void TextBoxCurrency_Validating(object sender, CancelEventArgs e)
        {
            this.ValidateCurrency((TextBox)sender, out _);
        }

        // Buttons

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            bool isValid =
                this.ValidateId(this.textBoxId, out _) & // Ignored
                this.ValidateName(this.textBoxName) &    // Values
                this.ValidateCurrency(this.textBoxProduction, out double production) &
                this.ValidateCurrency(this.textBoxBaseSalary, out double baseSalary) &
                this.ValidateCurrency(this.textBoxGratification, out double gratification);

            if (!isValid) return;

            double grossSalary;
            
            if (production >= 150)
            {
                grossSalary = CalculateSalaryWithBonuses(baseSalary, gratification, true, true, true);
            }
            else if (production >= 120)
            {
                grossSalary = CalculateSalaryWithBonuses(baseSalary, gratification, true, true);
            }
            else if (production >= 100)
            {
                grossSalary = CalculateSalaryWithBonuses(baseSalary, gratification, true);
            }
            else
            {
                grossSalary = CalculateSalaryWithBonuses(baseSalary, gratification);
            }

            if (gratification <= 0 || production < 150)
            {
                grossSalary = Math.Min(grossSalary, 7000);
            }

            this.textBoxGrossSalary.Text = grossSalary.ToString("N2");
        }
    }
}
