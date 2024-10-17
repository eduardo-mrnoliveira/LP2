namespace PClasses.Forms
{
    partial class SalariedEmployeeForm
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
            this.buttonInstantiate = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelWord1 = new System.Windows.Forms.Label();
            this.panelTextBoxId = new System.Windows.Forms.Panel();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.panelTextBoxName = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxMonthlySalary = new System.Windows.Forms.TextBox();
            this.labelMonthlySalary = new System.Windows.Forms.Label();
            this.panelTextBoxMonthlySalary = new System.Windows.Forms.Panel();
            this.textBoxCompanyEntryDate = new System.Windows.Forms.TextBox();
            this.labelCompanyEntryDate = new System.Windows.Forms.Label();
            this.panelTextBoxCompanyEntryDate = new System.Windows.Forms.Panel();
            this.panelTextBoxId.SuspendLayout();
            this.panelTextBoxName.SuspendLayout();
            this.panelTextBoxMonthlySalary.SuspendLayout();
            this.panelTextBoxCompanyEntryDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInstantiate
            // 
            this.buttonInstantiate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonInstantiate.FlatAppearance.BorderSize = 0;
            this.buttonInstantiate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInstantiate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonInstantiate.ForeColor = System.Drawing.Color.Black;
            this.buttonInstantiate.Location = new System.Drawing.Point(165, 306);
            this.buttonInstantiate.Name = "buttonInstantiate";
            this.buttonInstantiate.Size = new System.Drawing.Size(130, 43);
            this.buttonInstantiate.TabIndex = 4;
            this.buttonInstantiate.Text = "Instanciar";
            this.buttonInstantiate.UseVisualStyleBackColor = false;
            this.buttonInstantiate.Click += new System.EventHandler(this.ButtonInstantiate_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 81);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 21);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nome";
            // 
            // labelWord1
            // 
            this.labelWord1.AutoSize = true;
            this.labelWord1.Location = new System.Drawing.Point(12, 9);
            this.labelWord1.Name = "labelWord1";
            this.labelWord1.Size = new System.Drawing.Size(75, 21);
            this.labelWord1.TabIndex = 0;
            this.labelWord1.Text = "Matrícula";
            // 
            // panelTextBoxId
            // 
            this.panelTextBoxId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxId.Controls.Add(this.textBoxId);
            this.panelTextBoxId.Location = new System.Drawing.Point(16, 33);
            this.panelTextBoxId.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxId.Name = "panelTextBoxId";
            this.panelTextBoxId.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxId.Size = new System.Drawing.Size(432, 30);
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
            this.textBoxId.Size = new System.Drawing.Size(416, 22);
            this.textBoxId.TabIndex = 1;
            // 
            // panelTextBoxName
            // 
            this.panelTextBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxName.Controls.Add(this.textBoxName);
            this.panelTextBoxName.Location = new System.Drawing.Point(16, 105);
            this.panelTextBoxName.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxName.Name = "panelTextBoxName";
            this.panelTextBoxName.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxName.Size = new System.Drawing.Size(432, 30);
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
            this.textBoxName.Size = new System.Drawing.Size(416, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxMonthlySalary
            // 
            this.textBoxMonthlySalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxMonthlySalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMonthlySalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMonthlySalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxMonthlySalary.Location = new System.Drawing.Point(8, 4);
            this.textBoxMonthlySalary.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxMonthlySalary.Name = "textBoxMonthlySalary";
            this.textBoxMonthlySalary.Size = new System.Drawing.Size(416, 22);
            this.textBoxMonthlySalary.TabIndex = 2;
            // 
            // labelMonthlySalary
            // 
            this.labelMonthlySalary.AutoSize = true;
            this.labelMonthlySalary.Location = new System.Drawing.Point(12, 151);
            this.labelMonthlySalary.Name = "labelMonthlySalary";
            this.labelMonthlySalary.Size = new System.Drawing.Size(112, 21);
            this.labelMonthlySalary.TabIndex = 0;
            this.labelMonthlySalary.Text = "Salário Mensal";
            // 
            // panelTextBoxMonthlySalary
            // 
            this.panelTextBoxMonthlySalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxMonthlySalary.Controls.Add(this.textBoxMonthlySalary);
            this.panelTextBoxMonthlySalary.Location = new System.Drawing.Point(16, 175);
            this.panelTextBoxMonthlySalary.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxMonthlySalary.Name = "panelTextBoxMonthlySalary";
            this.panelTextBoxMonthlySalary.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxMonthlySalary.Size = new System.Drawing.Size(432, 30);
            this.panelTextBoxMonthlySalary.TabIndex = 2;
            // 
            // textBoxCompanyEntryDate
            // 
            this.textBoxCompanyEntryDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxCompanyEntryDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCompanyEntryDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCompanyEntryDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxCompanyEntryDate.Location = new System.Drawing.Point(8, 4);
            this.textBoxCompanyEntryDate.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxCompanyEntryDate.Name = "textBoxCompanyEntryDate";
            this.textBoxCompanyEntryDate.Size = new System.Drawing.Size(416, 22);
            this.textBoxCompanyEntryDate.TabIndex = 3;
            // 
            // labelCompanyEntryDate
            // 
            this.labelCompanyEntryDate.AutoSize = true;
            this.labelCompanyEntryDate.Location = new System.Drawing.Point(12, 222);
            this.labelCompanyEntryDate.Name = "labelCompanyEntryDate";
            this.labelCompanyEntryDate.Size = new System.Drawing.Size(205, 21);
            this.labelCompanyEntryDate.TabIndex = 0;
            this.labelCompanyEntryDate.Text = "Data de Entrada na Empresa";
            // 
            // panelTextBoxCompanyEntryDate
            // 
            this.panelTextBoxCompanyEntryDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxCompanyEntryDate.Controls.Add(this.textBoxCompanyEntryDate);
            this.panelTextBoxCompanyEntryDate.Location = new System.Drawing.Point(16, 246);
            this.panelTextBoxCompanyEntryDate.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxCompanyEntryDate.Name = "panelTextBoxCompanyEntryDate";
            this.panelTextBoxCompanyEntryDate.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxCompanyEntryDate.Size = new System.Drawing.Size(432, 30);
            this.panelTextBoxCompanyEntryDate.TabIndex = 3;
            // 
            // SalariedEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(464, 373);
            this.Controls.Add(this.labelCompanyEntryDate);
            this.Controls.Add(this.panelTextBoxCompanyEntryDate);
            this.Controls.Add(this.labelMonthlySalary);
            this.Controls.Add(this.panelTextBoxMonthlySalary);
            this.Controls.Add(this.buttonInstantiate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelWord1);
            this.Controls.Add(this.panelTextBoxId);
            this.Controls.Add(this.panelTextBoxName);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SalariedEmployeeForm";
            this.Text = "Mensalista";
            this.panelTextBoxId.ResumeLayout(false);
            this.panelTextBoxId.PerformLayout();
            this.panelTextBoxName.ResumeLayout(false);
            this.panelTextBoxName.PerformLayout();
            this.panelTextBoxMonthlySalary.ResumeLayout(false);
            this.panelTextBoxMonthlySalary.PerformLayout();
            this.panelTextBoxCompanyEntryDate.ResumeLayout(false);
            this.panelTextBoxCompanyEntryDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInstantiate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelWord1;
        private System.Windows.Forms.Panel panelTextBoxId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Panel panelTextBoxName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox textBoxMonthlySalary;
        private System.Windows.Forms.Label labelMonthlySalary;
        private System.Windows.Forms.Panel panelTextBoxMonthlySalary;
        private System.Windows.Forms.TextBox textBoxCompanyEntryDate;
        private System.Windows.Forms.Label labelCompanyEntryDate;
        private System.Windows.Forms.Panel panelTextBoxCompanyEntryDate;
    }
}