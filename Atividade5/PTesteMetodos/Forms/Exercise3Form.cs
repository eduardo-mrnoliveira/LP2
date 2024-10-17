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
    public partial class Exercise3Form : Form
    {
        public Exercise3Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.toolTip.SetToolTip(
                this.buttonRemoveOccurrences,
                "Remover todas as ocorrências da primeira palavra na segunda palavra e colocar o resultado na segunda palavra."
            );

            this.toolTip.SetToolTip(this.buttonReverse, "Inverter a primeira palavra.");
        }

        // Botões

        private void ButtonRemoveOccurrences_Click(object sender, EventArgs e)
        {
            string word1 = this.textBoxWord1.Text;

            if (word1.Length <= 0) return;

            this.textBoxWord2.Text = this.textBoxWord2.Text.Replace(word1, "");
        }

        private void ButtonReverse_Click(object sender, EventArgs e)
        {
            char[] reversedArr = this.textBoxWord1.Text.ToCharArray();
            Array.Reverse(reversedArr);

            this.textBoxReverse.Text = new String(reversedArr);
        }

        // Resetar inverso ao alterar as palavras

        private void TextBoxWord1_TextChanged(object sender, EventArgs e)
        {
            this.textBoxReverse.Clear();
        }
    }
}
