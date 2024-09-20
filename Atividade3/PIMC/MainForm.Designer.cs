namespace PIMC
{
    partial class MainForm
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
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelMaskedTextBoxWeight = new System.Windows.Forms.Panel();
            this.maskedTextBoxWeight = new System.Windows.Forms.MaskedTextBox();
            this.panelMaskedTextBoxHeight = new System.Windows.Forms.Panel();
            this.maskedTextBoxHeight = new System.Windows.Forms.MaskedTextBox();
            this.panelMaskedTextBoxIMC = new System.Windows.Forms.Panel();
            this.textBoxIMC = new System.Windows.Forms.TextBox();
            this.labelIMC = new System.Windows.Forms.Label();
            this.topBar = new PIMC.Controls.TopBar();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panelMaskedTextBoxWeight.SuspendLayout();
            this.panelMaskedTextBoxHeight.SuspendLayout();
            this.panelMaskedTextBoxIMC.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(24, 48);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(42, 21);
            this.labelWeight.TabIndex = 0;
            this.labelWeight.Text = "Peso";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(184, 48);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(52, 21);
            this.labelHeight.TabIndex = 0;
            this.labelHeight.Text = "Altura";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonCalculate.FlatAppearance.BorderSize = 0;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.Black;
            this.buttonCalculate.Location = new System.Drawing.Point(28, 206);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(130, 47);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Calcular";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(188, 206);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(130, 47);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Limpar";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // panelMaskedTextBoxWeight
            // 
            this.panelMaskedTextBoxWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelMaskedTextBoxWeight.Controls.Add(this.maskedTextBoxWeight);
            this.panelMaskedTextBoxWeight.Location = new System.Drawing.Point(28, 72);
            this.panelMaskedTextBoxWeight.Margin = new System.Windows.Forms.Padding(0);
            this.panelMaskedTextBoxWeight.Name = "panelMaskedTextBoxWeight";
            this.panelMaskedTextBoxWeight.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelMaskedTextBoxWeight.Size = new System.Drawing.Size(130, 30);
            this.panelMaskedTextBoxWeight.TabIndex = 1;
            // 
            // maskedTextBoxWeight
            // 
            this.maskedTextBoxWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.maskedTextBoxWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBoxWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.maskedTextBoxWeight.Location = new System.Drawing.Point(8, 4);
            this.maskedTextBoxWeight.Mask = "900.00";
            this.maskedTextBoxWeight.Name = "maskedTextBoxWeight";
            this.maskedTextBoxWeight.Size = new System.Drawing.Size(114, 22);
            this.maskedTextBoxWeight.TabIndex = 2;
            this.maskedTextBoxWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxWeight.Validating += new System.ComponentModel.CancelEventHandler(this.MaskedTextBoxWeight_Validating);
            // 
            // panelMaskedTextBoxHeight
            // 
            this.panelMaskedTextBoxHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelMaskedTextBoxHeight.Controls.Add(this.maskedTextBoxHeight);
            this.panelMaskedTextBoxHeight.Location = new System.Drawing.Point(188, 72);
            this.panelMaskedTextBoxHeight.Margin = new System.Windows.Forms.Padding(0);
            this.panelMaskedTextBoxHeight.Name = "panelMaskedTextBoxHeight";
            this.panelMaskedTextBoxHeight.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelMaskedTextBoxHeight.Size = new System.Drawing.Size(130, 30);
            this.panelMaskedTextBoxHeight.TabIndex = 2;
            // 
            // maskedTextBoxHeight
            // 
            this.maskedTextBoxHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.maskedTextBoxHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBoxHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.maskedTextBoxHeight.Location = new System.Drawing.Point(8, 4);
            this.maskedTextBoxHeight.Mask = "0.00";
            this.maskedTextBoxHeight.Name = "maskedTextBoxHeight";
            this.maskedTextBoxHeight.Size = new System.Drawing.Size(114, 22);
            this.maskedTextBoxHeight.TabIndex = 2;
            this.maskedTextBoxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxHeight.Validating += new System.ComponentModel.CancelEventHandler(this.MaskedTextBoxHeight_Validating);
            // 
            // panelMaskedTextBoxIMC
            // 
            this.panelMaskedTextBoxIMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelMaskedTextBoxIMC.Controls.Add(this.textBoxIMC);
            this.panelMaskedTextBoxIMC.Location = new System.Drawing.Point(28, 146);
            this.panelMaskedTextBoxIMC.Margin = new System.Windows.Forms.Padding(0);
            this.panelMaskedTextBoxIMC.Name = "panelMaskedTextBoxIMC";
            this.panelMaskedTextBoxIMC.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelMaskedTextBoxIMC.Size = new System.Drawing.Size(290, 30);
            this.panelMaskedTextBoxIMC.TabIndex = 0;
            // 
            // textBoxIMC
            // 
            this.textBoxIMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxIMC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIMC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIMC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxIMC.Location = new System.Drawing.Point(8, 4);
            this.textBoxIMC.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxIMC.Name = "textBoxIMC";
            this.textBoxIMC.ReadOnly = true;
            this.textBoxIMC.Size = new System.Drawing.Size(274, 22);
            this.textBoxIMC.TabIndex = 0;
            this.textBoxIMC.TabStop = false;
            this.textBoxIMC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelIMC
            // 
            this.labelIMC.AutoSize = true;
            this.labelIMC.Location = new System.Drawing.Point(24, 122);
            this.labelIMC.Name = "labelIMC";
            this.labelIMC.Size = new System.Drawing.Size(38, 21);
            this.labelIMC.TabIndex = 0;
            this.labelIMC.Text = "IMC";
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.Black;
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Margin = new System.Windows.Forms.Padding(0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(353, 38);
            this.topBar.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(353, 283);
            this.Controls.Add(this.panelMaskedTextBoxIMC);
            this.Controls.Add(this.panelMaskedTextBoxHeight);
            this.Controls.Add(this.labelIMC);
            this.Controls.Add(this.panelMaskedTextBoxWeight);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWeight);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volume";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panelMaskedTextBoxWeight.ResumeLayout(false);
            this.panelMaskedTextBoxWeight.PerformLayout();
            this.panelMaskedTextBoxHeight.ResumeLayout(false);
            this.panelMaskedTextBoxHeight.PerformLayout();
            this.panelMaskedTextBoxIMC.ResumeLayout(false);
            this.panelMaskedTextBoxIMC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panelMaskedTextBoxWeight;
        private System.Windows.Forms.Panel panelMaskedTextBoxHeight;
        private System.Windows.Forms.Panel panelMaskedTextBoxIMC;
        private System.Windows.Forms.TextBox textBoxIMC;
        private System.Windows.Forms.Label labelIMC;
        private Controls.TopBar topBar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWeight;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHeight;
    }
}

