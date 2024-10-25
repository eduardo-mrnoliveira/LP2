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

namespace PAtividade.Forms
{
    public partial class Exercise1Form : Form
    {
        public Exercise1Form()
        {
            InitializeComponent();
        }

        // Inicialização

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.toolTip.SetToolTip(
                this.buttonCountWhiteSpaces,
                "Contabiliza a quantidade de espaços em branco no texto."
            );

            this.toolTip.SetToolTip(
                this.buttonCountLettersR,
                "Contabiliza a quantidade de letras R no texto."
            );

            this.toolTip.SetToolTip(
                this.buttonCountLettersPairs,
                "Contabiliza o número de pares de letras no texto."
            );
        }

        // Botões

        private void ButtonCountWhiteSpaces_Click(object sender, EventArgs e)
        {
            string text = this.richTextBoxText.Text;

            int i = 0, count = 0;

            while (i < text.Length)
            {
                if (Char.IsWhiteSpace(text[i++])) count++;
            }

            this.textBoxWhiteSpaces.Text = count.ToString();
        }

        private void ButtonCountLettersR_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (var ch in this.richTextBoxText.Text)
            {
                if (Char.ToUpper(ch) == 'R') count++;
            }

            this.textBoxLettersR.Text = count.ToString();
        }

        private void ButtonCountLettersPairs_Click(object sender, EventArgs e)
        {
            string text = this.richTextBoxText.Text;

            int count = 0;

            for (int i = 1; i < text.Length; i++)
            {
                if (Char.ToLower(text[i]) == Char.ToLower(text[i - 1]))
                {
                    count++;
                    
                    i++; // Evitar que o par seja recontado
                }
            }

            this.textBoxLettersPairs.Text = count.ToString();
        }

        // Resetar valores ao alterar o texto

        private void RichTextBoxText_TextChanged(object sender, EventArgs e)
        {
            this.textBoxWhiteSpaces.Clear();
            this.textBoxLettersR.Clear();
            this.textBoxLettersPairs.Clear();
        }
    }
}
