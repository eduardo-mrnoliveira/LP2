namespace PTesteMetodos.Forms
{
    partial class Exercise4Form
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
            this.components = new System.ComponentModel.Container();
            this.buttonLocateWhiteSpace = new System.Windows.Forms.Button();
            this.buttonCountNumericChars = new System.Windows.Forms.Button();
            this.panelTextBoxNumericChars = new System.Windows.Forms.Panel();
            this.textBoxNumericChars = new System.Windows.Forms.TextBox();
            this.labelNumericChars = new System.Windows.Forms.Label();
            this.labelRichTextBox = new System.Windows.Forms.Label();
            this.panelRichTextBox = new System.Windows.Forms.Panel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.panelTextBoxFirstWhiteSpace = new System.Windows.Forms.Panel();
            this.textBoxFirstWhiteSpace = new System.Windows.Forms.TextBox();
            this.labelFirstWhiteSpace = new System.Windows.Forms.Label();
            this.panelTextBoxAlphaChars = new System.Windows.Forms.Panel();
            this.textBoxAlphaChars = new System.Windows.Forms.TextBox();
            this.labelAlphaChars = new System.Windows.Forms.Label();
            this.buttonCountAlphaChars = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelTextBoxNumericChars.SuspendLayout();
            this.panelRichTextBox.SuspendLayout();
            this.panelTextBoxFirstWhiteSpace.SuspendLayout();
            this.panelTextBoxAlphaChars.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLocateWhiteSpace
            // 
            this.buttonLocateWhiteSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonLocateWhiteSpace.FlatAppearance.BorderSize = 0;
            this.buttonLocateWhiteSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLocateWhiteSpace.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonLocateWhiteSpace.ForeColor = System.Drawing.Color.Black;
            this.buttonLocateWhiteSpace.Location = new System.Drawing.Point(249, 417);
            this.buttonLocateWhiteSpace.Name = "buttonLocateWhiteSpace";
            this.buttonLocateWhiteSpace.Size = new System.Drawing.Size(124, 46);
            this.buttonLocateWhiteSpace.TabIndex = 24;
            this.buttonLocateWhiteSpace.Text = "Localizar";
            this.buttonLocateWhiteSpace.UseVisualStyleBackColor = false;
            this.buttonLocateWhiteSpace.Click += new System.EventHandler(this.ButtonLocateWhiteSpace_Click);
            // 
            // buttonCountNumericChars
            // 
            this.buttonCountNumericChars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonCountNumericChars.FlatAppearance.BorderSize = 0;
            this.buttonCountNumericChars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCountNumericChars.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonCountNumericChars.ForeColor = System.Drawing.Color.Black;
            this.buttonCountNumericChars.Location = new System.Drawing.Point(40, 417);
            this.buttonCountNumericChars.Name = "buttonCountNumericChars";
            this.buttonCountNumericChars.Size = new System.Drawing.Size(124, 46);
            this.buttonCountNumericChars.TabIndex = 23;
            this.buttonCountNumericChars.Text = "Contar";
            this.buttonCountNumericChars.UseVisualStyleBackColor = false;
            this.buttonCountNumericChars.Click += new System.EventHandler(this.ButtonCountNumericChars_Click);
            // 
            // panelTextBoxNumericChars
            // 
            this.panelTextBoxNumericChars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxNumericChars.Controls.Add(this.textBoxNumericChars);
            this.panelTextBoxNumericChars.Location = new System.Drawing.Point(16, 373);
            this.panelTextBoxNumericChars.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxNumericChars.Name = "panelTextBoxNumericChars";
            this.panelTextBoxNumericChars.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxNumericChars.Size = new System.Drawing.Size(177, 30);
            this.panelTextBoxNumericChars.TabIndex = 25;
            // 
            // textBoxNumericChars
            // 
            this.textBoxNumericChars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxNumericChars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumericChars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNumericChars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxNumericChars.Location = new System.Drawing.Point(8, 4);
            this.textBoxNumericChars.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxNumericChars.Name = "textBoxNumericChars";
            this.textBoxNumericChars.ReadOnly = true;
            this.textBoxNumericChars.Size = new System.Drawing.Size(161, 22);
            this.textBoxNumericChars.TabIndex = 0;
            this.textBoxNumericChars.TabStop = false;
            this.textBoxNumericChars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNumericChars
            // 
            this.labelNumericChars.AutoSize = true;
            this.labelNumericChars.Location = new System.Drawing.Point(22, 349);
            this.labelNumericChars.Name = "labelNumericChars";
            this.labelNumericChars.Size = new System.Drawing.Size(163, 21);
            this.labelNumericChars.TabIndex = 26;
            this.labelNumericChars.Text = "Caracteres Numéricos";
            // 
            // labelRichTextBox
            // 
            this.labelRichTextBox.AutoSize = true;
            this.labelRichTextBox.Location = new System.Drawing.Point(12, 9);
            this.labelRichTextBox.Name = "labelRichTextBox";
            this.labelRichTextBox.Size = new System.Drawing.Size(45, 21);
            this.labelRichTextBox.TabIndex = 27;
            this.labelRichTextBox.Text = "Texto";
            // 
            // panelRichTextBox
            // 
            this.panelRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelRichTextBox.Controls.Add(this.richTextBox);
            this.panelRichTextBox.Location = new System.Drawing.Point(16, 33);
            this.panelRichTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.panelRichTextBox.Name = "panelRichTextBox";
            this.panelRichTextBox.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelRichTextBox.Size = new System.Drawing.Size(592, 302);
            this.panelRichTextBox.TabIndex = 28;
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox.Location = new System.Drawing.Point(8, 4);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox.Size = new System.Drawing.Size(576, 294);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
            // 
            // panelTextBoxFirstWhiteSpace
            // 
            this.panelTextBoxFirstWhiteSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxFirstWhiteSpace.Controls.Add(this.textBoxFirstWhiteSpace);
            this.panelTextBoxFirstWhiteSpace.Location = new System.Drawing.Point(223, 373);
            this.panelTextBoxFirstWhiteSpace.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxFirstWhiteSpace.Name = "panelTextBoxFirstWhiteSpace";
            this.panelTextBoxFirstWhiteSpace.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxFirstWhiteSpace.Size = new System.Drawing.Size(177, 30);
            this.panelTextBoxFirstWhiteSpace.TabIndex = 29;
            // 
            // textBoxFirstWhiteSpace
            // 
            this.textBoxFirstWhiteSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxFirstWhiteSpace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFirstWhiteSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFirstWhiteSpace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxFirstWhiteSpace.Location = new System.Drawing.Point(8, 4);
            this.textBoxFirstWhiteSpace.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxFirstWhiteSpace.Name = "textBoxFirstWhiteSpace";
            this.textBoxFirstWhiteSpace.ReadOnly = true;
            this.textBoxFirstWhiteSpace.Size = new System.Drawing.Size(161, 22);
            this.textBoxFirstWhiteSpace.TabIndex = 0;
            this.textBoxFirstWhiteSpace.TabStop = false;
            this.textBoxFirstWhiteSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFirstWhiteSpace
            // 
            this.labelFirstWhiteSpace.AutoSize = true;
            this.labelFirstWhiteSpace.Location = new System.Drawing.Point(249, 349);
            this.labelFirstWhiteSpace.Name = "labelFirstWhiteSpace";
            this.labelFirstWhiteSpace.Size = new System.Drawing.Size(122, 21);
            this.labelFirstWhiteSpace.TabIndex = 30;
            this.labelFirstWhiteSpace.Text = "Primeiro espaço";
            // 
            // panelTextBoxAlphaChars
            // 
            this.panelTextBoxAlphaChars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxAlphaChars.Controls.Add(this.textBoxAlphaChars);
            this.panelTextBoxAlphaChars.Location = new System.Drawing.Point(431, 373);
            this.panelTextBoxAlphaChars.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxAlphaChars.Name = "panelTextBoxAlphaChars";
            this.panelTextBoxAlphaChars.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxAlphaChars.Size = new System.Drawing.Size(177, 30);
            this.panelTextBoxAlphaChars.TabIndex = 31;
            // 
            // textBoxAlphaChars
            // 
            this.textBoxAlphaChars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxAlphaChars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlphaChars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAlphaChars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxAlphaChars.Location = new System.Drawing.Point(8, 4);
            this.textBoxAlphaChars.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAlphaChars.Name = "textBoxAlphaChars";
            this.textBoxAlphaChars.ReadOnly = true;
            this.textBoxAlphaChars.Size = new System.Drawing.Size(161, 22);
            this.textBoxAlphaChars.TabIndex = 0;
            this.textBoxAlphaChars.TabStop = false;
            this.textBoxAlphaChars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAlphaChars
            // 
            this.labelAlphaChars.AutoSize = true;
            this.labelAlphaChars.Location = new System.Drawing.Point(435, 349);
            this.labelAlphaChars.Name = "labelAlphaChars";
            this.labelAlphaChars.Size = new System.Drawing.Size(163, 21);
            this.labelAlphaChars.TabIndex = 32;
            this.labelAlphaChars.Text = "Caracteres Alfabéticos";
            // 
            // buttonCountAlphaChars
            // 
            this.buttonCountAlphaChars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonCountAlphaChars.FlatAppearance.BorderSize = 0;
            this.buttonCountAlphaChars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCountAlphaChars.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonCountAlphaChars.ForeColor = System.Drawing.Color.Black;
            this.buttonCountAlphaChars.Location = new System.Drawing.Point(458, 417);
            this.buttonCountAlphaChars.Name = "buttonCountAlphaChars";
            this.buttonCountAlphaChars.Size = new System.Drawing.Size(124, 46);
            this.buttonCountAlphaChars.TabIndex = 33;
            this.buttonCountAlphaChars.Text = "Contar";
            this.buttonCountAlphaChars.UseVisualStyleBackColor = false;
            this.buttonCountAlphaChars.Click += new System.EventHandler(this.ButtonCountAlphaChars_Click);
            // 
            // Exercise4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(624, 484);
            this.Controls.Add(this.buttonCountAlphaChars);
            this.Controls.Add(this.panelTextBoxAlphaChars);
            this.Controls.Add(this.labelAlphaChars);
            this.Controls.Add(this.panelTextBoxFirstWhiteSpace);
            this.Controls.Add(this.labelFirstWhiteSpace);
            this.Controls.Add(this.labelRichTextBox);
            this.Controls.Add(this.panelRichTextBox);
            this.Controls.Add(this.buttonLocateWhiteSpace);
            this.Controls.Add(this.buttonCountNumericChars);
            this.Controls.Add(this.panelTextBoxNumericChars);
            this.Controls.Add(this.labelNumericChars);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Exercise4Form";
            this.Text = "Exercício 4";
            this.panelTextBoxNumericChars.ResumeLayout(false);
            this.panelTextBoxNumericChars.PerformLayout();
            this.panelRichTextBox.ResumeLayout(false);
            this.panelTextBoxFirstWhiteSpace.ResumeLayout(false);
            this.panelTextBoxFirstWhiteSpace.PerformLayout();
            this.panelTextBoxAlphaChars.ResumeLayout(false);
            this.panelTextBoxAlphaChars.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLocateWhiteSpace;
        private System.Windows.Forms.Button buttonCountNumericChars;
        private System.Windows.Forms.Panel panelTextBoxNumericChars;
        private System.Windows.Forms.TextBox textBoxNumericChars;
        private System.Windows.Forms.Label labelNumericChars;
        private System.Windows.Forms.Label labelRichTextBox;
        private System.Windows.Forms.Panel panelRichTextBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Panel panelTextBoxFirstWhiteSpace;
        private System.Windows.Forms.TextBox textBoxFirstWhiteSpace;
        private System.Windows.Forms.Label labelFirstWhiteSpace;
        private System.Windows.Forms.Panel panelTextBoxAlphaChars;
        private System.Windows.Forms.TextBox textBoxAlphaChars;
        private System.Windows.Forms.Label labelAlphaChars;
        private System.Windows.Forms.Button buttonCountAlphaChars;
        private System.Windows.Forms.ToolTip toolTip;
    }
}