using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade.Forms
{
    public partial class Exercise3Form : Form
    {
        public Exercise3Form()
        {
            InitializeComponent();
        }

        // Botões

        private void ButtonVerify_Click(object sender, EventArgs e)
        {
            char[] palindromeArr =
                this.textBoxPalindrome.Text.ToCharArray()
                    .Where((ch) => !Char.IsWhiteSpace(ch)).ToArray(); // Filtrar espaços em branco

            string palindrome = new String(palindromeArr)
                .ToLower(); // Converter em minúsculo

            if (palindrome.Length <= 0)
            {
                this.textBoxResult.Text = "Não é um palíndromo";
                return;
            }

            int i = 0;
            int j = palindrome.Length - 1;

            while (i <= j)
            {
                if (palindrome[i++] != palindrome[j--])
                {
                    this.textBoxResult.Text = "Não é um palíndromo";
                    return;
                }
            }

            this.textBoxResult.Text = "É um palíndromo";
        }

        // Resetar resultado ao alterar o palíndromo

        private void TextBoxPalindrome_TextChanged(object sender, EventArgs e)
        {
            this.textBoxResult.Clear();
        }
    }
}
