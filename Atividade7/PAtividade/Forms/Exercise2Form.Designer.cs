namespace PAtividade.Forms
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelNumber = new System.Windows.Forms.Label();
            this.panelTextBoxNumber = new System.Windows.Forms.Panel();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.panelTextBoxResult = new System.Windows.Forms.Panel();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTextBoxNumber.SuspendLayout();
            this.panelTextBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonCalculate.FlatAppearance.BorderSize = 0;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.Black;
            this.buttonCalculate.Location = new System.Drawing.Point(74, 197);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(130, 47);
            this.buttonCalculate.TabIndex = 1;
            this.buttonCalculate.Text = "Calcular";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(16, 12);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(68, 21);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Número";
            // 
            // panelTextBoxNumber
            // 
            this.panelTextBoxNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxNumber.Controls.Add(this.textBoxNumber);
            this.panelTextBoxNumber.Location = new System.Drawing.Point(20, 36);
            this.panelTextBoxNumber.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxNumber.Name = "panelTextBoxNumber";
            this.panelTextBoxNumber.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxNumber.Size = new System.Drawing.Size(256, 30);
            this.panelTextBoxNumber.TabIndex = 0;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxNumber.Location = new System.Drawing.Point(8, 4);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(240, 22);
            this.textBoxNumber.TabIndex = 0;
            this.textBoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNumber.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNumber_Validating);
            // 
            // panelTextBoxResult
            // 
            this.panelTextBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxResult.Controls.Add(this.textBoxResult);
            this.panelTextBoxResult.Location = new System.Drawing.Point(20, 130);
            this.panelTextBoxResult.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxResult.Name = "panelTextBoxResult";
            this.panelTextBoxResult.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxResult.Size = new System.Drawing.Size(256, 30);
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
            this.textBoxResult.Size = new System.Drawing.Size(240, 22);
            this.textBoxResult.TabIndex = 2;
            this.textBoxResult.TabStop = false;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(16, 106);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(79, 21);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Resultado";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Exercise2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(292, 270);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.panelTextBoxNumber);
            this.Controls.Add(this.panelTextBoxResult);
            this.Controls.Add(this.labelResult);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Exercise2Form";
            this.Text = "Exercício 2";
            this.panelTextBoxNumber.ResumeLayout(false);
            this.panelTextBoxNumber.PerformLayout();
            this.panelTextBoxResult.ResumeLayout(false);
            this.panelTextBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Panel panelTextBoxNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Panel panelTextBoxResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}