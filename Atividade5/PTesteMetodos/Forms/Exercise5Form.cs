using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos.Forms
{
    public partial class Exercise5Form : Form
    {
        public Exercise5Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.errorProvider.SetIconPadding(this.textBoxMin, -16);
            this.errorProvider.SetIconPadding(this.textBoxMax, -16);
        }

        private bool ValidateInt(TextBox textBox, out int value)
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

        // Events

        private void TextBoxMin_Validating(object sender, CancelEventArgs e)
        {
            this.ValidateInt((TextBox)sender, out _);
        }

        private void TextBoxMax_Validating(object sender, CancelEventArgs e)
        {
            this.ValidateInt((TextBox)sender, out _);
        }

        // Buttons

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            bool isValid =
                this.ValidateInt(this.textBoxMin, out int min) &
                this.ValidateInt(this.textBoxMax, out int max);

            if (!isValid) return;

            if (min >= max)
            {
                this.errorProvider.SetError(this.textBoxMin, "Mínimo deve ser menor do que o máximo!");

                return;
            }

            Random random = new Random();

            // Inclusive max value
            int result = random.Next(min, max + 1);

            this.textBoxResult.Text = result.ToString();
        }
    }
}
