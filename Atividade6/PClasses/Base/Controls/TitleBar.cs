using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses.Base.Controls
{
    public partial class TitleBar : UserControl
    {
        public TitleBar()
        {
            InitializeComponent();

            this.Height = FIXED_HEIGHT;
        }

        // Properties

        private string _title = "";

        [Category("TitleBar")]
        [Description("Text displayed as the top bar title.")]
        [DefaultValue("")]
        public string TitleBarTitle
        {
            get { return this._title; }
            set {
                this._title = value;

                this.UpdateDisplayedTitle();
            }
        }

        private int _padding = 8;

        [Category("TitleBar")]
        [Description("Size in pixels of the top bar padding.")]
        [DefaultValue(8)]
        public int TitleBarPadding
        {
            get { return this._padding; }
            set
            {
                if (this.TitleBarResizable)
                {
                    int padding = Math.Max(value, RESIZE_BORDER_WIDTH);

                    this.Padding = new Padding(padding, 0, padding, 0);
                    this.panelDraggable.Padding = new Padding(0, 0, 0, 0);

                    this._padding = padding;
                }
                else
                {
                    this.Padding = new Padding(0, 0, 0, 0);
                    this.panelDraggable.Padding = new Padding(value, 0, value, 0);

                    this._padding = value;
                }

                this.UpdateDisplayedTitle();
            }
        }

        [Category("TitleBar")]
        [Description("Allow form resizing from the title bar.")]
        [DefaultValue(false)]
        public bool TitleBarResizable { get; set; } = false;

        // Buttons

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Title auto cropping

        private string TrimStringToFitWidth(string text, Font font, int maxWidth)
        {
            if (TextRenderer.MeasureText(text, font).Width <= maxWidth)
            {
                return text;
            }

            int left = 0;
            int right = text.Length;

            while (left < right)
            {
                int mid = (left + right + 1) / 2;

                string tmp = text.Substring(0, mid) + "...";

                if (TextRenderer.MeasureText(tmp, font).Width <= maxWidth)
                {
                    left = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }

            // If title can't be shown
            if (text.Substring(0, left).Length <= 0)
            {
                return String.Empty;
            }

            return text.Substring(0, left) + "...";
        }

        private void UpdateDisplayedTitle()
        {
            int maxLabelWidth =
                this.panelDraggable.Width
                - this.closeButton.Width
                - this.panelDraggable.Padding.Right * 2
                - this._padding;

            this.labelTitle.Text =
                TrimStringToFitWidth(this._title, this.labelTitle.Font, maxLabelWidth);
        }

        // Fixed height

        private const int FIXED_HEIGHT = 38;

        protected override void OnResize(EventArgs e)
        {
            this.Height = FIXED_HEIGHT;
            
            base.OnResize(e);

            this.UpdateDisplayedTitle();
        }

        // Dragging

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;

        private static readonly IntPtr HTCAPTION = new IntPtr(2);

        private void Draggable_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.ParentForm.Handle, WM_NCLBUTTONDOWN, HTCAPTION, IntPtr.Zero);
            }
        }

        // Resizing

        private const int RESIZE_BORDER_WIDTH = 4;

        private const int WM_NCHITTEST = 0x84;

        private static readonly IntPtr HTLEFT = new IntPtr(10);
        private static readonly IntPtr HTRIGHT = new IntPtr(11);
        private static readonly IntPtr HTTOP = new IntPtr(12);
        private static readonly IntPtr HTTOPLEFT = new IntPtr(13);
        private static readonly IntPtr HTTOPRIGHT = new IntPtr(14);

        private Rectangle TopResizeBorder => new Rectangle(0, 0, this.ClientSize.Width, RESIZE_BORDER_WIDTH);
        private Rectangle LeftResizeBorder => new Rectangle(0, 0, RESIZE_BORDER_WIDTH, this.ClientSize.Height);
        private Rectangle RightResizeBorder => new Rectangle(this.ClientSize.Width - RESIZE_BORDER_WIDTH, 0, RESIZE_BORDER_WIDTH, this.ClientSize.Height);

        private Rectangle TopLeftResizeCorner => new Rectangle(0, 0, RESIZE_BORDER_WIDTH, RESIZE_BORDER_WIDTH);
        private Rectangle TopRightResizeCorner => new Rectangle(this.ClientSize.Width - RESIZE_BORDER_WIDTH, 0, RESIZE_BORDER_WIDTH, RESIZE_BORDER_WIDTH);

        private IntPtr? HitTest(Point cursor)
        {
            if (this.TopLeftResizeCorner.Contains(cursor)) return HTTOPLEFT;

            if (this.TopRightResizeCorner.Contains(cursor)) return HTTOPRIGHT;

            if (this.TopResizeBorder.Contains(cursor)) return HTTOP;

            if (this.LeftResizeBorder.Contains(cursor)) return HTLEFT;

            if (this.RightResizeBorder.Contains(cursor)) return HTRIGHT;

            return null;
        }

        protected override void WndProc(ref Message message)
        {
            if (!this.TitleBarResizable)
            {
                base.WndProc(ref message);

                return;
            }

            message.HWnd = this.ParentForm.Handle;

            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST)
            {
                var cursor = this.PointToClient(Cursor.Position);

                IntPtr? result = HitTest(cursor);

                if (result.HasValue)
                {
                    message.Result = result.Value;
                }
            }
        }
    }
}
