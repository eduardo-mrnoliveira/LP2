namespace PTesteMetodos.Forms
{
    partial class Exercise2Form
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
            this.buttonCompare = new System.Windows.Forms.Button();
            this.labelWord2 = new System.Windows.Forms.Label();
            this.labelWord1 = new System.Windows.Forms.Label();
            this.panelTextBoxWord1 = new System.Windows.Forms.Panel();
            this.textBoxWord1 = new System.Windows.Forms.TextBox();
            this.buttonInsert1 = new System.Windows.Forms.Button();
            this.panelTextBoxWord2 = new System.Windows.Forms.Panel();
            this.textBoxWord2 = new System.Windows.Forms.TextBox();
            this.panelTextBoxComparison = new System.Windows.Forms.Panel();
            this.textBoxComparison = new System.Windows.Forms.TextBox();
            this.labelComparison = new System.Windows.Forms.Label();
            this.buttonInsert2 = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelTextBoxWord1.SuspendLayout();
            this.panelTextBoxWord2.SuspendLayout();
            this.panelTextBoxComparison.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCompare
            // 
            this.buttonCompare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonCompare.FlatAppearance.BorderSize = 0;
            this.buttonCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompare.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonCompare.ForeColor = System.Drawing.Color.Black;
            this.buttonCompare.Location = new System.Drawing.Point(168, 261);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(130, 47);
            this.buttonCompare.TabIndex = 4;
            this.buttonCompare.Text = "Comparar";
            this.buttonCompare.UseVisualStyleBackColor = false;
            this.buttonCompare.Click += new System.EventHandler(this.ButtonCompare_Click);
            // 
            // labelWord2
            // 
            this.labelWord2.AutoSize = true;
            this.labelWord2.Location = new System.Drawing.Point(12, 81);
            this.labelWord2.Name = "labelWord2";
            this.labelWord2.Size = new System.Drawing.Size(73, 21);
            this.labelWord2.TabIndex = 0;
            this.labelWord2.Text = "Palavra 2";
            // 
            // labelWord1
            // 
            this.labelWord1.AutoSize = true;
            this.labelWord1.Location = new System.Drawing.Point(12, 9);
            this.labelWord1.Name = "labelWord1";
            this.labelWord1.Size = new System.Drawing.Size(73, 21);
            this.labelWord1.TabIndex = 0;
            this.labelWord1.Text = "Palavra 1";
            // 
            // panelTextBoxWord1
            // 
            this.panelTextBoxWord1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxWord1.Controls.Add(this.textBoxWord1);
            this.panelTextBoxWord1.Location = new System.Drawing.Point(16, 33);
            this.panelTextBoxWord1.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxWord1.Name = "panelTextBoxWord1";
            this.panelTextBoxWord1.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxWord1.Size = new System.Drawing.Size(432, 30);
            this.panelTextBoxWord1.TabIndex = 1;
            // 
            // textBoxWord1
            // 
            this.textBoxWord1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxWord1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWord1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxWord1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxWord1.Location = new System.Drawing.Point(8, 4);
            this.textBoxWord1.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxWord1.Name = "textBoxWord1";
            this.textBoxWord1.Size = new System.Drawing.Size(416, 22);
            this.textBoxWord1.TabIndex = 1;
            this.textBoxWord1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxWord1.TextChanged += new System.EventHandler(this.TextBoxWord1_TextChanged);
            // 
            // buttonInsert1
            // 
            this.buttonInsert1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonInsert1.FlatAppearance.BorderSize = 0;
            this.buttonInsert1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonInsert1.ForeColor = System.Drawing.Color.Black;
            this.buttonInsert1.Location = new System.Drawing.Point(16, 261);
            this.buttonInsert1.Name = "buttonInsert1";
            this.buttonInsert1.Size = new System.Drawing.Size(130, 47);
            this.buttonInsert1.TabIndex = 3;
            this.buttonInsert1.Text = "Inserir (1)";
            this.buttonInsert1.UseVisualStyleBackColor = false;
            this.buttonInsert1.Click += new System.EventHandler(this.ButtonInsert1_Click);
            // 
            // panelTextBoxWord2
            // 
            this.panelTextBoxWord2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxWord2.Controls.Add(this.textBoxWord2);
            this.panelTextBoxWord2.Location = new System.Drawing.Point(16, 105);
            this.panelTextBoxWord2.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxWord2.Name = "panelTextBoxWord2";
            this.panelTextBoxWord2.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxWord2.Size = new System.Drawing.Size(432, 30);
            this.panelTextBoxWord2.TabIndex = 2;
            // 
            // textBoxWord2
            // 
            this.textBoxWord2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxWord2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWord2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxWord2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxWord2.Location = new System.Drawing.Point(8, 4);
            this.textBoxWord2.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxWord2.Name = "textBoxWord2";
            this.textBoxWord2.Size = new System.Drawing.Size(416, 22);
            this.textBoxWord2.TabIndex = 2;
            this.textBoxWord2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxWord2.TextChanged += new System.EventHandler(this.TextBoxWord2_TextChanged);
            // 
            // panelTextBoxComparison
            // 
            this.panelTextBoxComparison.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxComparison.Controls.Add(this.textBoxComparison);
            this.panelTextBoxComparison.Location = new System.Drawing.Point(16, 191);
            this.panelTextBoxComparison.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxComparison.Name = "panelTextBoxComparison";
            this.panelTextBoxComparison.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxComparison.Size = new System.Drawing.Size(432, 30);
            this.panelTextBoxComparison.TabIndex = 8;
            // 
            // textBoxComparison
            // 
            this.textBoxComparison.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxComparison.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxComparison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxComparison.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxComparison.Location = new System.Drawing.Point(8, 4);
            this.textBoxComparison.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxComparison.Name = "textBoxComparison";
            this.textBoxComparison.ReadOnly = true;
            this.textBoxComparison.Size = new System.Drawing.Size(416, 22);
            this.textBoxComparison.TabIndex = 0;
            this.textBoxComparison.TabStop = false;
            this.textBoxComparison.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelComparison
            // 
            this.labelComparison.AutoSize = true;
            this.labelComparison.Location = new System.Drawing.Point(12, 167);
            this.labelComparison.Name = "labelComparison";
            this.labelComparison.Size = new System.Drawing.Size(98, 21);
            this.labelComparison.TabIndex = 9;
            this.labelComparison.Text = "Comparação";
            // 
            // buttonInsert2
            // 
            this.buttonInsert2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonInsert2.FlatAppearance.BorderSize = 0;
            this.buttonInsert2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonInsert2.ForeColor = System.Drawing.Color.Black;
            this.buttonInsert2.Location = new System.Drawing.Point(318, 261);
            this.buttonInsert2.Name = "buttonInsert2";
            this.buttonInsert2.Size = new System.Drawing.Size(130, 47);
            this.buttonInsert2.TabIndex = 5;
            this.buttonInsert2.Text = "Inserir (2)";
            this.buttonInsert2.UseVisualStyleBackColor = false;
            this.buttonInsert2.Click += new System.EventHandler(this.ButtonInsert2_Click);
            // 
            // Exercise2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(464, 328);
            this.Controls.Add(this.buttonInsert2);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.labelWord2);
            this.Controls.Add(this.labelWord1);
            this.Controls.Add(this.panelTextBoxWord1);
            this.Controls.Add(this.buttonInsert1);
            this.Controls.Add(this.panelTextBoxWord2);
            this.Controls.Add(this.panelTextBoxComparison);
            this.Controls.Add(this.labelComparison);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Exercise2Form";
            this.Text = "Exercício 2";
            this.panelTextBoxWord1.ResumeLayout(false);
            this.panelTextBoxWord1.PerformLayout();
            this.panelTextBoxWord2.ResumeLayout(false);
            this.panelTextBoxWord2.PerformLayout();
            this.panelTextBoxComparison.ResumeLayout(false);
            this.panelTextBoxComparison.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.Label labelWord2;
        private System.Windows.Forms.Label labelWord1;
        private System.Windows.Forms.Panel panelTextBoxWord1;
        private System.Windows.Forms.TextBox textBoxWord1;
        private System.Windows.Forms.Button buttonInsert1;
        private System.Windows.Forms.Panel panelTextBoxWord2;
        private System.Windows.Forms.TextBox textBoxWord2;
        private System.Windows.Forms.Panel panelTextBoxComparison;
        private System.Windows.Forms.TextBox textBoxComparison;
        private System.Windows.Forms.Label labelComparison;
        private System.Windows.Forms.Button buttonInsert2;
        private System.Windows.Forms.ToolTip toolTip;
    }
}