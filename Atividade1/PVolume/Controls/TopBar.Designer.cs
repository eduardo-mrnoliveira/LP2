namespace PVolume.Controls
{
    partial class TopBar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopBar));
            this.panelDraggable = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDraggable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDraggable
            // 
            this.panelDraggable.BackColor = System.Drawing.Color.Black;
            this.panelDraggable.Controls.Add(this.closeButton);
            this.panelDraggable.Controls.Add(this.labelTitle);
            this.panelDraggable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDraggable.Location = new System.Drawing.Point(0, 0);
            this.panelDraggable.Margin = new System.Windows.Forms.Padding(0);
            this.panelDraggable.Name = "panelDraggable";
            this.panelDraggable.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.panelDraggable.Size = new System.Drawing.Size(547, 48);
            this.panelDraggable.TabIndex = 12;
            this.panelDraggable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.panelDraggable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageLocation = "";
            this.closeButton.Location = new System.Drawing.Point(520, 15);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(18, 18);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 0;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(9, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(187, 21);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Calculadora de Volume";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            // 
            // TopBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panelDraggable);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TopBar";
            this.Size = new System.Drawing.Size(547, 48);
            this.panelDraggable.ResumeLayout(false);
            this.panelDraggable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDraggable;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox closeButton;
    }
}
