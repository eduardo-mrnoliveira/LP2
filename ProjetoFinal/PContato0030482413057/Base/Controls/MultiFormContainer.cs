using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PContato0030482413057.Base.Controls
{
    public partial class MultiFormContainer : UserControl
    {
        private Form _activeMdiChild = null;

        private Size _excessSize = new Size();
        private Size _parentMinimumSize = new Size();

        public MultiFormContainer()
        {
            InitializeComponent();
        }

        // Events

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this._excessSize = this.ParentForm.Size - this.Size;
            this._parentMinimumSize = this.ParentForm.MinimumSize;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (this._activeMdiChild != null)
            {
                this._activeMdiChild.Size = this.Size;
            }
        }

        // Methods

        private void FitChildForm(Form form)
        {
            // Save parent form center

            Point centerPosition = new Point(
                this.ParentForm.Location.X + this.ParentForm.Width / 2,
                this.ParentForm.Location.Y + this.ParentForm.Height / 2
            );

            // Resize child form

            form.Size = new Size(
                Math.Max(this.Width, form.MinimumSize.Width),
                Math.Max(this.Height, form.MinimumSize.Height)
            );

            // Resize parent form

            Size minimumSize = form.MinimumSize + this._excessSize;

            this.ParentForm.MinimumSize = new Size(
                Math.Max(this._parentMinimumSize.Width, minimumSize.Width),
                Math.Max(this._parentMinimumSize.Height, minimumSize.Height)
            );

            if (this.ParentForm.WindowState == FormWindowState.Maximized) return;

            this.ParentForm.Size = form.Size + this._excessSize;

            this.ParentForm.Location = new Point(
                centerPosition.X - this.ParentForm.Width / 2,
                centerPosition.Y - this.ParentForm.Height / 2
            );
        }

        public void OpenForm<T>(T form) where T : Form
        {
            var openForm = this.Controls.OfType<T>().FirstOrDefault();

            if (openForm != null)
            {
                // Ignore if already active
                if (openForm == this._activeMdiChild) return;

                this._activeMdiChild = openForm;

                this.FitChildForm(openForm);

                openForm.BringToFront();
                openForm.Show();
            }
            else
            {
                this._activeMdiChild = form;

                this.FitChildForm(form);

                form.TopLevel = false;
                this.Controls.Add(form);

                form.BringToFront();
                form.Show();
            }
        }
    }
}
