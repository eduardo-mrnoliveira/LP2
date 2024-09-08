using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class MainForm : Form
    {
        double radius = 0;
        double height = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.errorProvider.SetIconPadding(this.textBoxRadius, -16);
            this.errorProvider.SetIconPadding(this.textBoxHeight, -16);
        }

        private bool ValidateRadius()
        {
            if (textBoxRadius.Text == "")
            {
                this.errorProvider.SetError(this.textBoxRadius, "Valor não pode estar vazio!");

                return false;
            }

            bool isDouble = Double.TryParse(this.textBoxRadius.Text, out radius);

            if (!isDouble)
            {
                this.errorProvider.SetError(this.textBoxRadius, "Valor inválido!");

                return false;
            }

            if (radius <= 0)
            {
                this.errorProvider.SetError(this.textBoxRadius, "Valor deve ser maior que zero!");

                return false;
            }

            this.errorProvider.SetError(this.textBoxRadius, "");

            return true;
        }

        private void TextBoxRadius_Validating(object sender, CancelEventArgs e)
        {
            this.ValidateRadius();
        }

        private bool ValidateHeight()
        {
            if (textBoxRadius.Text == "")
            {
                this.errorProvider.SetError(this.textBoxHeight, "Valor não pode estar vazio!");

                return false;
            }

            bool isDouble = Double.TryParse(this.textBoxHeight.Text, out height);

            if (!isDouble)
            {
                this.errorProvider.SetError(this.textBoxHeight, "Valor inválido!");

                return false;
            }

            if (height <= 0)
            {
                this.errorProvider.SetError(this.textBoxHeight, "Valor deve ser maior que zero!");

                return false;
            }

            this.errorProvider.SetError(this.textBoxHeight, "");

            return true;
        }

        private void TextBoxHeight_Validating(object sender, CancelEventArgs e)
        {
            ValidateHeight();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            bool isRadiusValid = ValidateRadius();
            bool isHeightValid = ValidateHeight();

            if (!isRadiusValid || !isHeightValid) return;

            double volume = Math.PI * Math.Pow(radius, 2) * height;

            this.textBoxVolume.Text = volume.ToString("N2");
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.textBoxRadius.Text = "";
            this.errorProvider.SetError(this.textBoxRadius, "");

            this.textBoxHeight.Text = "";
            this.errorProvider.SetError(this.textBoxHeight, "");

            this.textBoxVolume.Text = "";
        }
    }
}
