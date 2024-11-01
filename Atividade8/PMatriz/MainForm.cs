using PMatriz.Forms;
using PMatriz.Utils.ColorTables;
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

namespace PMatriz
{
    public partial class MainForm : Form
    {
        // Inicialização

        public MainForm()
        {
            InitializeComponent();

            this.menuStrip.Renderer = new ToolStripProfessionalRenderer(new MenuStripColorTable());
            this.menuStrip.ForeColor = Color.Black;

            this.contextMenuStrip.Renderer = new ToolStripProfessionalRenderer(new MenuStripColorTable());
            this.contextMenuStrip.ForeColor = Color.Black;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Formulário padrão

            this.OpenForm(new Exercise1To3Form());
        }

        // Métodos

        private void FitFormSize(Form form)
        {
            Point centerPosition = new Point(
                this.Location.X + this.Width / 2,
                this.Location.Y + this.Height / 2
            );

            this.Width = form.Width;
            this.Height = this.titleBar.Height + this.menuStrip.Height + form.Height;

            this.mdiPanel.Width = form.Width;
            this.mdiPanel.Height = form.Height;

            this.Location = new Point(
                centerPosition.X - this.Width / 2,
                centerPosition.Y - this.Height / 2
            );
        }

        private Form _activeMdiChild = null;

        private void OpenForm<T>(T form) where T : Form
        {
            var openForm = this.mdiPanel.Controls.OfType<T>().FirstOrDefault();

            if (openForm != null)
            {
                // Ignore if already active
                if (openForm == this._activeMdiChild) return;

                this._activeMdiChild = openForm;

                this.FitFormSize(openForm);

                this.titleBar.TitleBarTitle = $"Atividade 8 - {openForm.Text}";

                openForm.BringToFront();
            }
            else
            {
                this._activeMdiChild = form;

                this.FitFormSize(form);

                form.TopLevel = false;
                this.mdiPanel.Controls.Add(form);

                this.titleBar.TitleBarTitle = $"Atividade 8 - {form.Text}";

                form.BringToFront();
                form.Show();
            }
        }

        // Botões

        private void Exercise1To3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenForm(new Exercise1To3Form());
        }

        private void Exercise4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenForm(new Exercise4Form());
        }

        private void Exercise5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenForm(new Exercise5Form());
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
