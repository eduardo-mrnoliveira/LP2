using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalc
{
    public partial class MainForm : Form
    {
        double number1 = 0;
        double number2 = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.errorProvider.SetIconPadding(this.textBoxNumber1, -16);
            this.errorProvider.SetIconPadding(this.textBoxNumber2, -16);
        }

        private bool ValidateNumber(TextBox textBox, ref double number)
        {
            if (textBoxNumber1.Text == "")
            {
                this.errorProvider.SetError(textBox, "Valor não pode estar vazio!");

                return false;
            }

            bool isDouble = Double.TryParse(textBox.Text, out number);

            if (!isDouble)
            {
                this.errorProvider.SetError(textBox, "Valor inválido!");

                return false;
            }

            this.errorProvider.SetError(textBox, "");

            return true;
        }

        private void TextBoxNumber1_Validating(object sender, CancelEventArgs e)
        {
            this.ValidateNumber(this.textBoxNumber1, ref this.number1);
        }

        private void TextBoxNumber2_Validating(object sender, CancelEventArgs e)
        {
            this.ValidateNumber(this.textBoxNumber2, ref this.number2);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            bool isNumber1Valid = ValidateNumber(this.textBoxNumber1, ref this.number1);
            bool isNumber2Valid = ValidateNumber(this.textBoxNumber2, ref this.number2);

            if (!isNumber1Valid || !isNumber2Valid) return;

            double result = number1 + number2;

            this.textBoxResult.Text = result.ToString("N2");
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            bool isNumber1Valid = ValidateNumber(this.textBoxNumber1, ref this.number1);
            bool isNumber2Valid = ValidateNumber(this.textBoxNumber2, ref this.number2);

            if (!isNumber1Valid || !isNumber2Valid) return;

            double result = number1 - number2;

            this.textBoxResult.Text = result.ToString("N2");
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            bool isNumber1Valid = ValidateNumber(this.textBoxNumber1, ref this.number1);
            bool isNumber2Valid = ValidateNumber(this.textBoxNumber2, ref this.number2);

            if (!isNumber1Valid || !isNumber2Valid) return;

            double result = number1 * number2;

            this.textBoxResult.Text = result.ToString("N2");
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            bool isNumber1Valid = ValidateNumber(this.textBoxNumber1, ref this.number1);
            bool isNumber2Valid = ValidateNumber(this.textBoxNumber2, ref this.number2);

            if (!isNumber1Valid || !isNumber2Valid) return;

            if (number2 == 0)
            {
                this.errorProvider.SetError(this.textBoxNumber2, "Não é possível dividir por zero!");

                return;
            }

            double result = number1 / number2;

            this.textBoxResult.Text = result.ToString("N2");
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.textBoxNumber1.Text = "";
            this.errorProvider.SetError(this.textBoxNumber1, "");

            this.textBoxNumber2.Text = "";
            this.errorProvider.SetError(this.textBoxNumber2, "");

            this.textBoxResult.Text = "";
        }
    }
}
