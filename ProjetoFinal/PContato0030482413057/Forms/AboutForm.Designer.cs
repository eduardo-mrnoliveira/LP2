namespace PContato0030482413057.Forms
{
    partial class AboutForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.labelStudent1 = new System.Windows.Forms.Label();
            this.labelStudent2 = new System.Windows.Forms.Label();
            this.labelStudent3 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStudent1
            // 
            this.labelStudent1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStudent1.Location = new System.Drawing.Point(12, 58);
            this.labelStudent1.Name = "labelStudent1";
            this.labelStudent1.Size = new System.Drawing.Size(1256, 37);
            this.labelStudent1.TabIndex = 1;
            this.labelStudent1.Text = "Eduardo Oliveira - 0030482413041";
            this.labelStudent1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStudent2
            // 
            this.labelStudent2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStudent2.Location = new System.Drawing.Point(12, 104);
            this.labelStudent2.Name = "labelStudent2";
            this.labelStudent2.Size = new System.Drawing.Size(1256, 37);
            this.labelStudent2.TabIndex = 2;
            this.labelStudent2.Text = "Gabriel Ramalho - 0030482413027";
            this.labelStudent2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStudent3
            // 
            this.labelStudent3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStudent3.Location = new System.Drawing.Point(12, 153);
            this.labelStudent3.Name = "labelStudent3";
            this.labelStudent3.Size = new System.Drawing.Size(1256, 37);
            this.labelStudent3.TabIndex = 3;
            this.labelStudent3.Text = "Raul Messias - 0030482413057";
            this.labelStudent3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(12, 263);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1256, 400);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Tag = "";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.labelStudent3);
            this.Controls.Add(this.labelStudent2);
            this.Controls.Add(this.labelStudent1);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AboutForm";
            this.Text = "Sobre";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelStudent1;
        private System.Windows.Forms.Label labelStudent2;
        private System.Windows.Forms.Label labelStudent3;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}