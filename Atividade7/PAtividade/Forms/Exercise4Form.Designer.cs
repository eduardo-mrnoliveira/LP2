namespace PAtividade.Forms
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelBaseSalary = new System.Windows.Forms.Label();
            this.labelProduction = new System.Windows.Forms.Label();
            this.panelTextBoxProduction = new System.Windows.Forms.Panel();
            this.textBoxProduction = new System.Windows.Forms.TextBox();
            this.panelTextBoxBaseSalary = new System.Windows.Forms.Panel();
            this.textBoxBaseSalary = new System.Windows.Forms.TextBox();
            this.panelTextBoxGrossSalary = new System.Windows.Forms.Panel();
            this.textBoxGrossSalary = new System.Windows.Forms.TextBox();
            this.labelGrossSalary = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelGratification = new System.Windows.Forms.Label();
            this.panelTextBoxGratification = new System.Windows.Forms.Panel();
            this.textBoxGratification = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panelTextBoxName = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.panelTextBoxId = new System.Windows.Forms.Panel();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelTextBoxProduction.SuspendLayout();
            this.panelTextBoxBaseSalary.SuspendLayout();
            this.panelTextBoxGrossSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panelTextBoxGratification.SuspendLayout();
            this.panelTextBoxName.SuspendLayout();
            this.panelTextBoxId.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonCalculate.FlatAppearance.BorderSize = 0;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.Black;
            this.buttonCalculate.Location = new System.Drawing.Point(269, 189);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(130, 47);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Calcular";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // labelBaseSalary
            // 
            this.labelBaseSalary.AutoSize = true;
            this.labelBaseSalary.Location = new System.Drawing.Point(241, 93);
            this.labelBaseSalary.Name = "labelBaseSalary";
            this.labelBaseSalary.Size = new System.Drawing.Size(58, 21);
            this.labelBaseSalary.TabIndex = 0;
            this.labelBaseSalary.Text = "Salário";
            // 
            // labelProduction
            // 
            this.labelProduction.AutoSize = true;
            this.labelProduction.Location = new System.Drawing.Point(21, 93);
            this.labelProduction.Name = "labelProduction";
            this.labelProduction.Size = new System.Drawing.Size(76, 21);
            this.labelProduction.TabIndex = 0;
            this.labelProduction.Text = "Produção";
            // 
            // panelTextBoxProduction
            // 
            this.panelTextBoxProduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxProduction.Controls.Add(this.textBoxProduction);
            this.panelTextBoxProduction.Location = new System.Drawing.Point(25, 117);
            this.panelTextBoxProduction.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxProduction.Name = "panelTextBoxProduction";
            this.panelTextBoxProduction.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxProduction.Size = new System.Drawing.Size(180, 30);
            this.panelTextBoxProduction.TabIndex = 2;
            // 
            // textBoxProduction
            // 
            this.textBoxProduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxProduction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxProduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxProduction.Location = new System.Drawing.Point(8, 4);
            this.textBoxProduction.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxProduction.Name = "textBoxProduction";
            this.textBoxProduction.Size = new System.Drawing.Size(164, 22);
            this.textBoxProduction.TabIndex = 2;
            this.textBoxProduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxProduction.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxCurrency_Validating);
            // 
            // panelTextBoxBaseSalary
            // 
            this.panelTextBoxBaseSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxBaseSalary.Controls.Add(this.textBoxBaseSalary);
            this.panelTextBoxBaseSalary.Location = new System.Drawing.Point(245, 117);
            this.panelTextBoxBaseSalary.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxBaseSalary.Name = "panelTextBoxBaseSalary";
            this.panelTextBoxBaseSalary.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxBaseSalary.Size = new System.Drawing.Size(180, 30);
            this.panelTextBoxBaseSalary.TabIndex = 3;
            // 
            // textBoxBaseSalary
            // 
            this.textBoxBaseSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxBaseSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBaseSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBaseSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxBaseSalary.Location = new System.Drawing.Point(8, 4);
            this.textBoxBaseSalary.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxBaseSalary.Name = "textBoxBaseSalary";
            this.textBoxBaseSalary.Size = new System.Drawing.Size(164, 22);
            this.textBoxBaseSalary.TabIndex = 3;
            this.textBoxBaseSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBaseSalary.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxCurrency_Validating);
            // 
            // panelTextBoxGrossSalary
            // 
            this.panelTextBoxGrossSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxGrossSalary.Controls.Add(this.textBoxGrossSalary);
            this.panelTextBoxGrossSalary.Location = new System.Drawing.Point(245, 288);
            this.panelTextBoxGrossSalary.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxGrossSalary.Name = "panelTextBoxGrossSalary";
            this.panelTextBoxGrossSalary.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxGrossSalary.Size = new System.Drawing.Size(180, 30);
            this.panelTextBoxGrossSalary.TabIndex = 6;
            // 
            // textBoxGrossSalary
            // 
            this.textBoxGrossSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxGrossSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGrossSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGrossSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxGrossSalary.Location = new System.Drawing.Point(8, 4);
            this.textBoxGrossSalary.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxGrossSalary.Name = "textBoxGrossSalary";
            this.textBoxGrossSalary.ReadOnly = true;
            this.textBoxGrossSalary.Size = new System.Drawing.Size(164, 22);
            this.textBoxGrossSalary.TabIndex = 6;
            this.textBoxGrossSalary.TabStop = false;
            this.textBoxGrossSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelGrossSalary
            // 
            this.labelGrossSalary.AutoSize = true;
            this.labelGrossSalary.Location = new System.Drawing.Point(241, 264);
            this.labelGrossSalary.Name = "labelGrossSalary";
            this.labelGrossSalary.Size = new System.Drawing.Size(100, 21);
            this.labelGrossSalary.TabIndex = 0;
            this.labelGrossSalary.Text = "Salário Bruto";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // labelGratification
            // 
            this.labelGratification.AutoSize = true;
            this.labelGratification.Location = new System.Drawing.Point(461, 93);
            this.labelGratification.Name = "labelGratification";
            this.labelGratification.Size = new System.Drawing.Size(92, 21);
            this.labelGratification.TabIndex = 0;
            this.labelGratification.Text = "Gratificação";
            // 
            // panelTextBoxGratification
            // 
            this.panelTextBoxGratification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxGratification.Controls.Add(this.textBoxGratification);
            this.panelTextBoxGratification.Location = new System.Drawing.Point(465, 117);
            this.panelTextBoxGratification.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxGratification.Name = "panelTextBoxGratification";
            this.panelTextBoxGratification.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxGratification.Size = new System.Drawing.Size(180, 30);
            this.panelTextBoxGratification.TabIndex = 4;
            // 
            // textBoxGratification
            // 
            this.textBoxGratification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxGratification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGratification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGratification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxGratification.Location = new System.Drawing.Point(8, 4);
            this.textBoxGratification.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxGratification.Name = "textBoxGratification";
            this.textBoxGratification.Size = new System.Drawing.Size(164, 22);
            this.textBoxGratification.TabIndex = 4;
            this.textBoxGratification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxGratification.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxCurrency_Validating);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(204, 17);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 21);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nome";
            // 
            // panelTextBoxName
            // 
            this.panelTextBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxName.Controls.Add(this.textBoxName);
            this.panelTextBoxName.Location = new System.Drawing.Point(208, 41);
            this.panelTextBoxName.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxName.Name = "panelTextBoxName";
            this.panelTextBoxName.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxName.Size = new System.Drawing.Size(437, 30);
            this.panelTextBoxName.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxName.Location = new System.Drawing.Point(8, 4);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(421, 22);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxName_Validating);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(21, 17);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(75, 21);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Matrícula";
            // 
            // panelTextBoxId
            // 
            this.panelTextBoxId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxId.Controls.Add(this.textBoxId);
            this.panelTextBoxId.Location = new System.Drawing.Point(25, 41);
            this.panelTextBoxId.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxId.Name = "panelTextBoxId";
            this.panelTextBoxId.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxId.Size = new System.Drawing.Size(144, 30);
            this.panelTextBoxId.TabIndex = 0;
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxId.Location = new System.Drawing.Point(8, 4);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(128, 22);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxId.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxId_Validating);
            // 
            // Exercise4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(671, 350);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.panelTextBoxId);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.panelTextBoxName);
            this.Controls.Add(this.labelGratification);
            this.Controls.Add(this.panelTextBoxGratification);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelBaseSalary);
            this.Controls.Add(this.labelProduction);
            this.Controls.Add(this.panelTextBoxProduction);
            this.Controls.Add(this.panelTextBoxBaseSalary);
            this.Controls.Add(this.panelTextBoxGrossSalary);
            this.Controls.Add(this.labelGrossSalary);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Exercise4Form";
            this.Text = "Exercício 4";
            this.panelTextBoxProduction.ResumeLayout(false);
            this.panelTextBoxProduction.PerformLayout();
            this.panelTextBoxBaseSalary.ResumeLayout(false);
            this.panelTextBoxBaseSalary.PerformLayout();
            this.panelTextBoxGrossSalary.ResumeLayout(false);
            this.panelTextBoxGrossSalary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panelTextBoxGratification.ResumeLayout(false);
            this.panelTextBoxGratification.PerformLayout();
            this.panelTextBoxName.ResumeLayout(false);
            this.panelTextBoxName.PerformLayout();
            this.panelTextBoxId.ResumeLayout(false);
            this.panelTextBoxId.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelBaseSalary;
        private System.Windows.Forms.Label labelProduction;
        private System.Windows.Forms.Panel panelTextBoxProduction;
        private System.Windows.Forms.TextBox textBoxProduction;
        private System.Windows.Forms.Panel panelTextBoxBaseSalary;
        private System.Windows.Forms.TextBox textBoxBaseSalary;
        private System.Windows.Forms.Panel panelTextBoxGrossSalary;
        private System.Windows.Forms.TextBox textBoxGrossSalary;
        private System.Windows.Forms.Label labelGrossSalary;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Panel panelTextBoxId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelTextBoxName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelGratification;
        private System.Windows.Forms.Panel panelTextBoxGratification;
        private System.Windows.Forms.TextBox textBoxGratification;
        private System.Windows.Forms.ToolTip toolTip;
    }
}