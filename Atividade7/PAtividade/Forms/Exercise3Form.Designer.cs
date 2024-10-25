namespace PAtividade.Forms
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
            this.buttonVerify = new System.Windows.Forms.Button();
            this.labelPalindrome = new System.Windows.Forms.Label();
            this.panelTextBoxPalindrome = new System.Windows.Forms.Panel();
            this.textBoxPalindrome = new System.Windows.Forms.TextBox();
            this.panelTextBoxResult = new System.Windows.Forms.Panel();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.panelTextBoxPalindrome.SuspendLayout();
            this.panelTextBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonVerify
            // 
            this.buttonVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonVerify.FlatAppearance.BorderSize = 0;
            this.buttonVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerify.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonVerify.ForeColor = System.Drawing.Color.Black;
            this.buttonVerify.Location = new System.Drawing.Point(125, 180);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(130, 51);
            this.buttonVerify.TabIndex = 1;
            this.buttonVerify.Text = "Verificar";
            this.buttonVerify.UseVisualStyleBackColor = false;
            this.buttonVerify.Click += new System.EventHandler(this.ButtonVerify_Click);
            // 
            // labelPalindrome
            // 
            this.labelPalindrome.AutoSize = true;
            this.labelPalindrome.Location = new System.Drawing.Point(12, 9);
            this.labelPalindrome.Name = "labelPalindrome";
            this.labelPalindrome.Size = new System.Drawing.Size(90, 21);
            this.labelPalindrome.TabIndex = 0;
            this.labelPalindrome.Text = "Palíndromo";
            // 
            // panelTextBoxPalindrome
            // 
            this.panelTextBoxPalindrome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxPalindrome.Controls.Add(this.textBoxPalindrome);
            this.panelTextBoxPalindrome.Location = new System.Drawing.Point(16, 33);
            this.panelTextBoxPalindrome.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxPalindrome.Name = "panelTextBoxPalindrome";
            this.panelTextBoxPalindrome.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxPalindrome.Size = new System.Drawing.Size(357, 30);
            this.panelTextBoxPalindrome.TabIndex = 0;
            // 
            // textBoxPalindrome
            // 
            this.textBoxPalindrome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxPalindrome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPalindrome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPalindrome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxPalindrome.Location = new System.Drawing.Point(8, 4);
            this.textBoxPalindrome.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPalindrome.MaxLength = 50;
            this.textBoxPalindrome.Name = "textBoxPalindrome";
            this.textBoxPalindrome.Size = new System.Drawing.Size(341, 22);
            this.textBoxPalindrome.TabIndex = 0;
            this.textBoxPalindrome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPalindrome.TextChanged += new System.EventHandler(this.TextBoxPalindrome_TextChanged);
            // 
            // panelTextBoxResult
            // 
            this.panelTextBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxResult.Controls.Add(this.textBoxResult);
            this.panelTextBoxResult.Location = new System.Drawing.Point(16, 115);
            this.panelTextBoxResult.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxResult.Name = "panelTextBoxResult";
            this.panelTextBoxResult.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxResult.Size = new System.Drawing.Size(357, 30);
            this.panelTextBoxResult.TabIndex = 2;
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
            this.textBoxResult.Size = new System.Drawing.Size(341, 22);
            this.textBoxResult.TabIndex = 2;
            this.textBoxResult.TabStop = false;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 91);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(79, 21);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Resultado";
            // 
            // Exercise3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(389, 256);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.labelPalindrome);
            this.Controls.Add(this.panelTextBoxPalindrome);
            this.Controls.Add(this.panelTextBoxResult);
            this.Controls.Add(this.labelResult);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Exercise3Form";
            this.Text = "Exercício 3";
            this.panelTextBoxPalindrome.ResumeLayout(false);
            this.panelTextBoxPalindrome.PerformLayout();
            this.panelTextBoxResult.ResumeLayout(false);
            this.panelTextBoxResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.Label labelPalindrome;
        private System.Windows.Forms.Panel panelTextBoxPalindrome;
        private System.Windows.Forms.TextBox textBoxPalindrome;
        private System.Windows.Forms.Panel panelTextBoxResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
    }
}