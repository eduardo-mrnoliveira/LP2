using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PMatriz.Forms
{
    public partial class Exercise5Form : Form
    {
        public Exercise5Form()
        {
            InitializeComponent();
        }

        // Botões

        private void ButtonExecute_Click(object sender, EventArgs e)
        {
            this.listBoxTestResults.Items.Clear();

            // 041
            const int N = 2;

            char[] validAnswers = { 'A', 'B', 'C', 'D', 'E' };
            char[] correctAnswers = new char[10] { 'A', 'B', 'C', 'D', 'E', 'A', 'B', 'C', 'D', 'E' };

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < correctAnswers.Length; j++)
                {
                    string answerStr = Interaction.InputBox($"Insira a resposta da questão {j + 1}.", $"Entrada de Dados - Aluno {i + 1}");

                    // Cancelar
                    if (answerStr == "") return;

                    char answer = answerStr[0];

                    if (answerStr.Length > 1 || !validAnswers.Contains(answer))
                    {
                        MessageBox.Show($"As respostas só podem ser A, B, C, D, ou E (Maiúsculas).");
                        j--; // Voltar uma iteração
                        continue;
                    }

                    string status = answer == correctAnswers[j] ? "acertou" : "errou";

                    this.listBoxTestResults.Items.Add($"O aluno {i + 1} {status} a questão {j + 1}: Era {correctAnswers[j]} - Escolheu {answer}");
                }
            }
        }
    }
}
