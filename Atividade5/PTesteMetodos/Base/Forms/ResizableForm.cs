using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PTesteMetodos.Base.Forms
{
    public class ResizableForm : Form
    {
        private const int RESIZE_BORDER_WIDTH = 4;

        private const int WM_NCHITTEST = 0x84;

        private static readonly IntPtr HTLEFT = new IntPtr(10);
        private static readonly IntPtr HTRIGHT = new IntPtr(11);
        private static readonly IntPtr HTTOP = new IntPtr(12);
        private static readonly IntPtr HTTOPLEFT = new IntPtr(13);
        private static readonly IntPtr HTTOPRIGHT = new IntPtr(14);
        private static readonly IntPtr HTBOTTOM = new IntPtr(15);
        private static readonly IntPtr HTBOTTOMLEFT = new IntPtr(16);
        private static readonly IntPtr HTBOTTOMRIGHT = new IntPtr(17);

        private Rectangle TopResizeBorder => new Rectangle(0, 0, this.ClientSize.Width, RESIZE_BORDER_WIDTH);
        private Rectangle LeftResizeBorder => new Rectangle(0, 0, RESIZE_BORDER_WIDTH, this.ClientSize.Height);
        private Rectangle BottomResizeBorder => new Rectangle(0, this.ClientSize.Height - RESIZE_BORDER_WIDTH, this.ClientSize.Width, RESIZE_BORDER_WIDTH);
        private Rectangle RightResizeBorder => new Rectangle(this.ClientSize.Width - RESIZE_BORDER_WIDTH, 0, RESIZE_BORDER_WIDTH, this.ClientSize.Height);

        private Rectangle TopLeftResizeCorner => new Rectangle(0, 0, RESIZE_BORDER_WIDTH, RESIZE_BORDER_WIDTH);
        private Rectangle TopRightResizeCorner => new Rectangle(this.ClientSize.Width - RESIZE_BORDER_WIDTH, 0, RESIZE_BORDER_WIDTH, RESIZE_BORDER_WIDTH);
        private Rectangle BottomLeftResizeCorner => new Rectangle(0, this.ClientSize.Height - RESIZE_BORDER_WIDTH, RESIZE_BORDER_WIDTH, RESIZE_BORDER_WIDTH);
        private Rectangle BottomRightResizeCorner => new Rectangle(this.ClientSize.Width - RESIZE_BORDER_WIDTH, this.ClientSize.Height - RESIZE_BORDER_WIDTH, RESIZE_BORDER_WIDTH, RESIZE_BORDER_WIDTH);

        public ResizableForm()
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private IntPtr? HitTest(Point cursor)
        {
            if (this.TopLeftResizeCorner.Contains(cursor)) return HTTOPLEFT;

            if (this.TopRightResizeCorner.Contains(cursor)) return HTTOPRIGHT;

            if (this.BottomLeftResizeCorner.Contains(cursor)) return HTBOTTOMLEFT;

            if (this.BottomRightResizeCorner.Contains(cursor)) return HTBOTTOMRIGHT;

            if (this.TopResizeBorder.Contains(cursor)) return HTTOP;

            if (this.LeftResizeBorder.Contains(cursor)) return HTLEFT;

            if (this.RightResizeBorder.Contains(cursor)) return HTRIGHT;

            if (this.BottomResizeBorder.Contains(cursor)) return HTBOTTOM;

            return null;
        }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST)
            {
                var cursor = this.PointToClient(Cursor.Position);

                IntPtr? result = this.HitTest(cursor);

                if (result.HasValue)
                {
                    message.Result = result.Value;
                }
            }
        }
    }
}
