﻿using PClasses.Forms;
using PClasses.Utils.ColorTables;
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

namespace PClasses
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.menuStrip.Renderer = new ToolStripProfessionalRenderer(new MenuStripColorTable());
            this.menuStrip.ForeColor = Color.Black;

            this.contextMenuStrip.Renderer = new ToolStripProfessionalRenderer(new MenuStripColorTable());
            this.contextMenuStrip.ForeColor = Color.Black;
        }

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

                this.titleBar.TitleBarTitle = $"Atividade 6 - {openForm.Text}";

                openForm.BringToFront();
            }
            else
            {
                this._activeMdiChild = form;

                this.FitFormSize(form);

                form.TopLevel = false;
                this.mdiPanel.Controls.Add(form);

                this.titleBar.TitleBarTitle = $"Atividade 6 - {form.Text}";

                form.BringToFront();
                form.Show();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Default form

            this.OpenForm(new SalariedEmployeeForm());
        }

        private void SalariedEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenForm(new SalariedEmployeeForm());
        }

        private void HourlyEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenForm(new HourlyEmployeeForm());
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}