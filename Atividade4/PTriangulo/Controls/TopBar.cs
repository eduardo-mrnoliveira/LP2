using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTriangulo.Controls
{
    public partial class TopBar : UserControl
    {
        private Point dragStartLocation = new Point();

        public TopBar()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Draggable_MouseDown(object sender, MouseEventArgs e)
        {
            this.dragStartLocation = e.Location;
        }

        private void Draggable_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Parent.Location = new Point(
                    (this.Parent.Location.X - this.dragStartLocation.X) + e.X,
                    (this.Parent.Location.Y - this.dragStartLocation.Y) + e.Y
                );

                this.Parent.Update();
            }
        }
    }
}
