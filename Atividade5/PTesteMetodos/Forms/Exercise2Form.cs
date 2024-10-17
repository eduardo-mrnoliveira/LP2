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
    public partial class Exercise2Form : Form
    {
        public Exercise2Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.toolTip.SetToolTip(
                this.buttonInsert1,
                "Inserir primeira palavra no meio da segunda palavra e colocar o resultado na segunda palavra."
            );

            this.toolTip.SetToolTip(
                this.buttonInsert2,
                "Inserir dois asteriscos no meio da primeira palavra e colocar o resultado na segunda palavra."
            );
        }

        // Botões

        private void ButtonCompare_Click(object sender, EventArgs e)
        {
            int comparison = String.Compare(this.textBoxWord1.Text, this.textBoxWord2.Text);

            if (comparison == 0)
            {
                this.textBoxComparison.Text = "Iguais";
            }
            else
            {
                this.textBoxComparison.Text = "Diferentes";
            }
        }

        private void ButtonInsert1_Click(object sender, EventArgs e)
        {
            string word1 = this.textBoxWord1.Text;
            string word2 = this.textBoxWord2.Text;

            int middle = (int)Math.Ceiling(word2.Length / 2.0);

            string word2FirstHalf = word2.Substring(0, middle);
            string word2SecondHalf = word2.Substring(middle);

            this.textBoxWord2.Text = word2FirstHalf + word1 + word2SecondHalf;
        }

        private void ButtonInsert2_Click(object sender, EventArgs e)
        {
            int middle = (int)Math.Ceiling(this.textBoxWord1.Text.Length / 2.0);

            string result = this.textBoxWord1.Text.Insert(middle, "**");

            this.textBoxWord2.Text = result;
        }

        // Resetar comparação ao alterar as palavras

        private void TextBoxWord1_TextChanged(object sender, EventArgs e)
        {
            this.textBoxComparison.Clear();
        }

        private void TextBoxWord2_TextChanged(object sender, EventArgs e)
        {
            this.textBoxComparison.Clear();
        }
    }
}
