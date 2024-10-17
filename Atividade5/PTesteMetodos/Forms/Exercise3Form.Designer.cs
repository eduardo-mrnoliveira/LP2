namespace PTesteMetodos.Forms
{
    partial class Exercise3Form
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
            this.buttonReverse = new System.Windows.Forms.Button();
            this.labelWord2 = new System.Windows.Forms.Label();
            this.labelWord1 = new System.Windows.Forms.Label();
            this.panelTextBoxWord1 = new System.Windows.Forms.Panel();
            this.textBoxWord1 = new System.Windows.Forms.TextBox();
            this.buttonRemoveOccurrences = new System.Windows.Forms.Button();
            this.panelTextBoxWord2 = new System.Windows.Forms.Panel();
            this.textBoxWord2 = new System.Windows.Forms.TextBox();
            this.panelTextBoxReverse = new System.Windows.Forms.Panel();
            this.textBoxReverse = new System.Windows.Forms.TextBox();
            this.labelComparison = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelTextBoxWord1.SuspendLayout();
            this.panelTextBoxWord2.SuspendLayout();
            this.panelTextBoxReverse.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReverse
            // 
            this.buttonReverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonReverse.FlatAppearance.BorderSize = 0;
            this.buttonReverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReverse.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonReverse.ForeColor = System.Drawing.Color.Black;
            this.buttonReverse.Location = new System.Drawing.Point(167, 261);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(130, 63);
            this.buttonReverse.TabIndex = 4;
            this.buttonReverse.Text = "Inverter";
            this.buttonReverse.UseVisualStyleBackColor = false;
            this.buttonReverse.Click += new System.EventHandler(this.ButtonReverse_Click);
            // 
            // labelWord2
            // 
            this.labelWord2.AutoSize = true;
            this.labelWord2.Location = new System.Drawing.Point(12, 81);
            this.labelWord2.Name = "labelWord2";
            this.labelWord2.Size = new System.Drawing.Size(73, 21);
            this.labelWord2.TabIndex = 17;
            this.labelWord2.Text = "Palavra 2";
            // 
            // labelWord1
            // 
            this.labelWord1.AutoSize = true;
            this.labelWord1.Location = new System.Drawing.Point(12, 9);
            this.labelWord1.Name = "labelWord1";
            this.labelWord1.Size = new System.Drawing.Size(73, 21);
            this.labelWord1.TabIndex = 18;
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
            this.panelTextBoxWord1.Size = new System.Drawing.Size(281, 30);
            this.panelTextBoxWord1.TabIndex = 19;
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
            this.textBoxWord1.Size = new System.Drawing.Size(265, 22);
            this.textBoxWord1.TabIndex = 1;
            this.textBoxWord1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxWord1.TextChanged += new System.EventHandler(this.TextBoxWord1_TextChanged);
            // 
            // buttonRemoveOccurrences
            // 
            this.buttonRemoveOccurrences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonRemoveOccurrences.FlatAppearance.BorderSize = 0;
            this.buttonRemoveOccurrences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveOccurrences.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonRemoveOccurrences.ForeColor = System.Drawing.Color.Black;
            this.buttonRemoveOccurrences.Location = new System.Drawing.Point(16, 261);
            this.buttonRemoveOccurrences.Name = "buttonRemoveOccurrences";
            this.buttonRemoveOccurrences.Size = new System.Drawing.Size(130, 63);
            this.buttonRemoveOccurrences.TabIndex = 3;
            this.buttonRemoveOccurrences.Text = "Remover ocorrências";
            this.buttonRemoveOccurrences.UseVisualStyleBackColor = false;
            this.buttonRemoveOccurrences.Click += new System.EventHandler(this.ButtonRemoveOccurrences_Click);
            // 
            // panelTextBoxWord2
            // 
            this.panelTextBoxWord2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxWord2.Controls.Add(this.textBoxWord2);
            this.panelTextBoxWord2.Location = new System.Drawing.Point(16, 105);
            this.panelTextBoxWord2.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxWord2.Name = "panelTextBoxWord2";
            this.panelTextBoxWord2.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxWord2.Size = new System.Drawing.Size(281, 30);
            this.panelTextBoxWord2.TabIndex = 20;
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
            this.textBoxWord2.Size = new System.Drawing.Size(265, 22);
            this.textBoxWord2.TabIndex = 2;
            this.textBoxWord2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelTextBoxReverse
            // 
            this.panelTextBoxReverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxReverse.Controls.Add(this.textBoxReverse);
            this.panelTextBoxReverse.Location = new System.Drawing.Point(16, 191);
            this.panelTextBoxReverse.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxReverse.Name = "panelTextBoxReverse";
            this.panelTextBoxReverse.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxReverse.Size = new System.Drawing.Size(281, 30);
            this.panelTextBoxReverse.TabIndex = 21;
            // 
            // textBoxReverse
            // 
            this.textBoxReverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxReverse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxReverse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxReverse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxReverse.Location = new System.Drawing.Point(8, 4);
            this.textBoxReverse.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxReverse.Name = "textBoxReverse";
            this.textBoxReverse.ReadOnly = true;
            this.textBoxReverse.Size = new System.Drawing.Size(265, 22);
            this.textBoxReverse.TabIndex = 0;
            this.textBoxReverse.TabStop = false;
            this.textBoxReverse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelComparison
            // 
            this.labelComparison.AutoSize = true;
            this.labelComparison.Location = new System.Drawing.Point(12, 167);
            this.labelComparison.Name = "labelComparison";
            this.labelComparison.Size = new System.Drawing.Size(61, 21);
            this.labelComparison.TabIndex = 22;
            this.labelComparison.Text = "Inverso";
            // 
            // Exercise3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(314, 345);
            this.Controls.Add(this.buttonReverse);
            this.Controls.Add(this.labelWord2);
            this.Controls.Add(this.labelWord1);
            this.Controls.Add(this.panelTextBoxWord1);
            this.Controls.Add(this.buttonRemoveOccurrences);
            this.Controls.Add(this.panelTextBoxWord2);
            this.Controls.Add(this.panelTextBoxReverse);
            this.Controls.Add(this.labelComparison);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Exercise3Form";
            this.Text = "Exercício 3";
            this.panelTextBoxWord1.ResumeLayout(false);
            this.panelTextBoxWord1.PerformLayout();
            this.panelTextBoxWord2.ResumeLayout(false);
            this.panelTextBoxWord2.PerformLayout();
            this.panelTextBoxReverse.ResumeLayout(false);
            this.panelTextBoxReverse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReverse;
        private System.Windows.Forms.Label labelWord2;
        private System.Windows.Forms.Label labelWord1;
        private System.Windows.Forms.Panel panelTextBoxWord1;
        private System.Windows.Forms.TextBox textBoxWord1;
        private System.Windows.Forms.Button buttonRemoveOccurrences;
        private System.Windows.Forms.Panel panelTextBoxWord2;
        private System.Windows.Forms.TextBox textBoxWord2;
        private System.Windows.Forms.Panel panelTextBoxReverse;
        private System.Windows.Forms.TextBox textBoxReverse;
        private System.Windows.Forms.Label labelComparison;
        private System.Windows.Forms.ToolTip toolTip;
    }
}