namespace PTesteMetodos.Forms
{
    partial class Exercise5Form
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
            this.buttonSort = new System.Windows.Forms.Button();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.panelTextBoxMin = new System.Windows.Forms.Panel();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.panelTextBoxMax = new System.Windows.Forms.Panel();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.panelTextBoxResult = new System.Windows.Forms.Panel();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTextBoxMin.SuspendLayout();
            this.panelTextBoxMax.SuspendLayout();
            this.panelTextBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonSort.FlatAppearance.BorderSize = 0;
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSort.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonSort.ForeColor = System.Drawing.Color.Black;
            this.buttonSort.Location = new System.Drawing.Point(73, 250);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(130, 47);
            this.buttonSort.TabIndex = 15;
            this.buttonSort.Text = "Sortear";
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(12, 81);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(141, 21);
            this.labelMax.TabIndex = 10;
            this.labelMax.Text = "Máximo (Inclusivo)";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(12, 9);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(139, 21);
            this.labelMin.TabIndex = 11;
            this.labelMin.Text = "Mínimo (Inclusivo)";
            // 
            // panelTextBoxMin
            // 
            this.panelTextBoxMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxMin.Controls.Add(this.textBoxMin);
            this.panelTextBoxMin.Location = new System.Drawing.Point(16, 33);
            this.panelTextBoxMin.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxMin.Name = "panelTextBoxMin";
            this.panelTextBoxMin.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxMin.Size = new System.Drawing.Size(259, 30);
            this.panelTextBoxMin.TabIndex = 12;
            // 
            // textBoxMin
            // 
            this.textBoxMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxMin.Location = new System.Drawing.Point(8, 4);
            this.textBoxMin.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(243, 22);
            this.textBoxMin.TabIndex = 1;
            this.textBoxMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMin.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxMin_Validating);
            // 
            // panelTextBoxMax
            // 
            this.panelTextBoxMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxMax.Controls.Add(this.textBoxMax);
            this.panelTextBoxMax.Location = new System.Drawing.Point(16, 105);
            this.panelTextBoxMax.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxMax.Name = "panelTextBoxMax";
            this.panelTextBoxMax.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxMax.Size = new System.Drawing.Size(259, 30);
            this.panelTextBoxMax.TabIndex = 13;
            // 
            // textBoxMax
            // 
            this.textBoxMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxMax.Location = new System.Drawing.Point(8, 4);
            this.textBoxMax.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(243, 22);
            this.textBoxMax.TabIndex = 2;
            this.textBoxMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMax.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxMax_Validating);
            // 
            // panelTextBoxResult
            // 
            this.panelTextBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxResult.Controls.Add(this.textBoxResult);
            this.panelTextBoxResult.Location = new System.Drawing.Point(16, 191);
            this.panelTextBoxResult.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxResult.Name = "panelTextBoxResult";
            this.panelTextBoxResult.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxResult.Size = new System.Drawing.Size(259, 30);
            this.panelTextBoxResult.TabIndex = 17;
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxResult.Location = new System.Drawing.Point(8, 4);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(243, 22);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.TabStop = false;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 167);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(79, 21);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Resultado";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Exercise5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(292, 321);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.panelTextBoxMin);
            this.Controls.Add(this.panelTextBoxMax);
            this.Controls.Add(this.panelTextBoxResult);
            this.Controls.Add(this.labelResult);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Exercise5Form";
            this.Text = "Exercício 5";
            this.panelTextBoxMin.ResumeLayout(false);
            this.panelTextBoxMin.PerformLayout();
            this.panelTextBoxMax.ResumeLayout(false);
            this.panelTextBoxMax.PerformLayout();
            this.panelTextBoxResult.ResumeLayout(false);
            this.panelTextBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Panel panelTextBoxMin;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Panel panelTextBoxMax;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Panel panelTextBoxResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}