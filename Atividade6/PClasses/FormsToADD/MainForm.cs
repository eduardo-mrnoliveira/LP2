using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.errorProvider.SetIconPadding(this.textBoxSide1, -16);
            this.errorProvider.SetIconPadding(this.textBoxSide2, -16);
            this.errorProvider.SetIconPadding(this.textBoxSide3, -16);
        }

        private bool ValidateSide(TextBox textBox, out double side)
        {
            bool isDouble = Double.TryParse(textBox.Text, out side);

            if (!isDouble)
            {
                this.errorProvider.SetError(textBox, "Valor inválido!");

                return false;
            }

            if (side <= 0)
            {
                this.errorProvider.SetError(textBox, "Lado deve ser maior que zero!");

                return false;
            }

            this.errorProvider.SetError(textBox, "");

            return true;
        }

        private void TextBoxSide_Validating(object sender, CancelEventArgs e)
        {
            this.ValidateSide((TextBox)sender, out _);
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            bool isValid =
                ValidateSide(this.textBoxSide1, out double side1) &
                ValidateSide(this.textBoxSide2, out double side2) &
                ValidateSide(this.textBoxSide3, out double side3);

            if (!isValid) return;

            if (side1 >= (side2 + side3) || side2 >= (side1 + side3) || side3 >= (side1 + side2))
            {
                this.textBoxResult.Text = "Não forma um triângulo";

                return;
            }

            if (side1 == side2 && side1 == side3)
            {
                this.textBoxResult.Text = "Triângulo equilátero";

                return;
            }

            if (side1 != side2 && side1 != side3 && side2 != side3)
            {
                this.textBoxResult.Text = "Triângulo escaleno";

                return;
            }

            this.textBoxResult.Text = "Triângulo isósceles";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.textBoxSide1.Clear();
            this.errorProvider.SetError(this.textBoxSide1, "");

            this.textBoxSide2.Clear();
            this.errorProvider.SetError(this.textBoxSide2, "");

            this.textBoxSide3.Clear();
            this.errorProvider.SetError(this.textBoxSide3, "");

            this.textBoxResult.Clear();
        }
    }
}
