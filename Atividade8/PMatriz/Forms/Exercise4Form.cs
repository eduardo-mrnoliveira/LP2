using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMatriz.Forms
{
    public partial class Exercise4Form : Form
    {
        public Exercise4Form()
        {
            InitializeComponent();
        }

        // Botões

        private void ButtonExecute_Click(object sender, EventArgs e)
        {
            this.listBoxNames.Items.Clear();

            string[] names = new string[10];
            int[] namesLength = new int[names.Length];

            for (int i = 0; i < names.Length; i++)
            {
                string name = Interaction.InputBox($"Insira o {i + 1}° nome.", "Entrada de Dados");

                // Cancelar
                if (name == "") return;

                names[i] = name;

                // Tamanho sem espaços
                namesLength[i] = name.Replace(" ", "").Length;

                this.listBoxNames.Items.Add($"O nome \"{names[i]}\" tem {namesLength[i]} caracteres");
            }
        }
    }
}
