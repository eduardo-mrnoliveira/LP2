using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PTesteMetodos.Forms
{
    public partial class Exercise4Form : Form
    {
        public Exercise4Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.toolTip.SetToolTip(
                this.buttonCountNumericChars,
                "Contabiliza a quantidade de caracteres numéricos no texto."
            );

            this.toolTip.SetToolTip(
                this.buttonLocateWhiteSpace,
                "Encontra a posição do primeiro espaço em branco no texto."
            );

            this.toolTip.SetToolTip(
                this.buttonCountAlphaChars,
                "Contabiliza a quantidade de caracteres alfabéticos no texto."
            );
        }

        // Botões

        private void ButtonCountNumericChars_Click(object sender, EventArgs e)
        {
            string text = this.richTextBox.Text;

            int length = text.Length;

            int i = 0, count = 0;

            while (i < length)
            {
                if (Char.IsNumber(text[i++])) count++;
            }

            this.textBoxNumericChars.Text = count.ToString();
        }

        private void ButtonLocateWhiteSpace_Click(object sender, EventArgs e)
        {
            string text = this.richTextBox.Text;

            int length = text.Length;

            for (int i = 0; i < length; i++)
            {
                if (Char.IsWhiteSpace(text[i]))
                {
                    this.textBoxFirstWhiteSpace.Text = $"{i + 1}° caractere";
                    
                    return;
                }
            }

            this.textBoxFirstWhiteSpace.Text = "Não encontrado";
        }

        private void ButtonCountAlphaChars_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (var ch in this.richTextBox.Text)
            {
                if (Char.IsLetter(ch)) count++;
            }

            this.textBoxAlphaChars.Text = count.ToString();
        }

        // Resetar valores ao alterar o texto

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            this.textBoxNumericChars.Clear();
            this.textBoxFirstWhiteSpace.Clear();
            this.textBoxAlphaChars.Clear();
        }
    }
}
