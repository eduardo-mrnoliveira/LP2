using PContato0030482413057.Forms;
using PContato0030482413057.Utils.ColorTables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PContato0030482413057
{
    public partial class MainForm : Form
    {
        // Inicialização

        public MainForm()
        {
            InitializeComponent();

            var menuStripColorTable = new MenuStripColorTable(
                backgroundColor: ColorTranslator.FromHtml("#f8f8f8"),
                itemSelectionColor: ColorTranslator.FromHtml("#e4e4e4"),
                itemPressedColor: ColorTranslator.FromHtml("#b8b8b8")
            );

            this.menuStrip.Renderer = new ToolStripProfessionalRenderer(menuStripColorTable);
            this.menuStrip.ForeColor = Color.Black;

            this.contextMenuStrip.Renderer = new ToolStripProfessionalRenderer(menuStripColorTable);
            this.contextMenuStrip.ForeColor = Color.Black;

            this.WindowState = FormWindowState.Maximized;
        }

        private void OpenForm<T>(T form) where T : Form
        {
            this.Text = $"Projeto Final - {form.Text}";
            this.multiFormContainer.OpenForm(form);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Formulário padrão

            this.OpenForm(new ContactsForm());
        }

        // Botões

        private void ContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenForm(new ContactsForm());
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenForm(new AboutForm());
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
