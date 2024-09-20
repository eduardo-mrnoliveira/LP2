using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMC
{
    public partial class MainForm : Form
    {
        double weight = 0;
        double height = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.errorProvider.SetIconPadding(this.maskedTextBoxWeight, -16);
            this.errorProvider.SetIconPadding(this.maskedTextBoxHeight, -16);
        }

        private bool ValidateWeight()
        {
            bool isDouble = Double.TryParse(this.maskedTextBoxWeight.Text, out this.weight);

            if (!isDouble)
            {
                this.errorProvider.SetError(this.maskedTextBoxWeight, "Peso inválido!");

                return false;
            }

            if (weight <= 0)
            {
                this.errorProvider.SetError(this.maskedTextBoxWeight, "Peso deve ser maior que zero!");

                return false;
            }

            this.errorProvider.SetError(this.maskedTextBoxWeight, "");

            return true;
        }

        private void MaskedTextBoxWeight_Validating(object sender, CancelEventArgs e)
        {
            this.ValidateWeight();
        }

        private bool ValidateHeight()
        {
            bool isDouble = Double.TryParse(this.maskedTextBoxHeight.Text, out this.height);

            if (!isDouble)
            {
                this.errorProvider.SetError(this.maskedTextBoxHeight, "Altura inválida!");

                return false;
            }

            if (height <= 0)
            {
                this.errorProvider.SetError(this.maskedTextBoxHeight, "Altura deve ser maior que zero!");

                return false;
            }

            this.errorProvider.SetError(this.maskedTextBoxHeight, "");

            return true;
        }

        private void MaskedTextBoxHeight_Validating(object sender, CancelEventArgs e)
        {
            this.ValidateHeight();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateWeight() & ValidateHeight();

            if (!isValid) return;

            double imc = Math.Round(this.weight / Math.Pow(this.height, 2), 1);

            string classification;

            if (imc < 18.5)
            {
                classification = "Magreza";
            }
            else if (imc < 25) {
                classification = "Normal";
            }
            else if (imc < 30)
            {
                classification = "Sobrepeso (Grau I)";
            }
            else if (imc < 40)
            {
                classification = "Obesidade (Grau II)";
            }
            else
            {
                classification = "Obesidade grave (Grau III)";
            }

            this.textBoxIMC.Text = $"{imc} - {classification}";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.maskedTextBoxWeight.Clear();
            this.errorProvider.SetError(this.maskedTextBoxWeight, "");

            this.maskedTextBoxHeight.Clear();
            this.errorProvider.SetError(this.maskedTextBoxHeight, "");

            this.textBoxIMC.Clear();
        }
    }
}
