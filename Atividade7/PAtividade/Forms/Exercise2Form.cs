using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade.Forms
{
    public partial class Exercise2Form : Form
    {
        public Exercise2Form()
        {
            InitializeComponent();
        }

        // Métodos

        private bool ValidateNumber(TextBox textBox, out int value)
        {
            bool isInt = int.TryParse(textBox.Text, out value);

            if (!isInt)
            {
                this.errorProvider.SetError(textBox, "Valor inválido!");

                return false;
            }

            if (value <= 0)
            {
                this.errorProvider.SetError(textBox, "Valor deve ser maior que zero!");

                return false;
            }

            this.errorProvider.SetError(textBox, "");

            return true;
        }

        // Eventos

        private void TextBoxNumber_Validating(object sender, CancelEventArgs e)
        {
            this.ValidateNumber((TextBox)sender, out _);
        }

        // Botões

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            bool isValid = this.ValidateNumber(this.textBoxNumber, out int number);

            if (!isValid) return;

            double result = 1;

            for (int i = 2; i <= number; i++)
            {
                result += 1.0 / i;
            }

            this.textBoxResult.Text = result.ToString("N5");
        }
    }
}
