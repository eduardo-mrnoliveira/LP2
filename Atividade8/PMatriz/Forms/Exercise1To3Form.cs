using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PMatriz.Forms
{
    public partial class Exercise1To3Form : Form
    {
        public Exercise1To3Form()
        {
            InitializeComponent();
        }

        // Botões

        private void ButtonExercise1_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[20];

            for (int i = 0; i < numbers.Length; i++)
            {
                string number = Interaction.InputBox($"Insira o {i + 1}° número inteiro.", "Entrada de Dados");

                // Cancelar
                if (number == "") return;

                bool isValid = int.TryParse(number, out numbers[(numbers.Length - 1) - i]);
                if (!isValid)
                {
                    MessageBox.Show($"Número inválido.");
                    i--; // Voltar uma iteração
                    continue;
                }
            }

            string message = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                message += $"{numbers[i]}\n";
            }

            MessageBox.Show(message);
        }

        private void ButtonExercise2_Click(object sender, EventArgs e)
        {
            ArrayList students = new ArrayList()
            {
                "Ana",
                "André",
                "Débora",
                "Fátima",
                "João",
                "Janete",
                "Otávio",
                "Marcelo",
                "Pedro",
                "Thais"
            };

            // Remover Otávio
            students.RemoveAt(students.IndexOf("Otávio"));

            string message = "";

            for (int i = 0; i < students.Count; i++)
            {
                message += $"{students[i]}\n";
            }

            MessageBox.Show(message);
        }

        private void ButtonExercise3_Click(object sender, EventArgs e)
        {
            double[,] grades = new double[20, 3];

            for (int i = 0; i < grades.GetLength(0); i++)
            {
                for (int j = 0; j < grades.GetLength(1); j++)
                {
                    string grade = Interaction.InputBox($"Insira a {j + 1}ª nota do aluno {i + 1}.", "Entrada de Dados");

                    // Cancelar
                    if (grade == "") return;

                    bool isValid = double.TryParse(grade, out grades[i, j]);
                    
                    if (!isValid)
                    {
                        MessageBox.Show($"Número inválido.");
                        j--; // Voltar uma iteração
                        continue;
                    }

                    if (grades[i, j] < 0 || grades[i, j] > 10)
                    {
                        MessageBox.Show($"Número deve estar entre 0 e 10.");
                        j--; // Voltar uma iteração
                        continue;
                    }
                }
            }

            string message = "";

            for (int i = 0; i < grades.GetLength(0); i++)
            {
                double sum = 0;

                for (int j = 0; j < grades.GetLength(1); j++)
                {
                    sum += grades[i, j];
                }

                double average = sum / grades.GetLength(1);

                message += $"Aluno {i + 1} - Média: {average.ToString("N1")}\n";
            }

            MessageBox.Show(message);
        }
    }
}
