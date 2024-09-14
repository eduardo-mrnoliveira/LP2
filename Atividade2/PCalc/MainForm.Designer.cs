namespace PCalc
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
            this.labelNumber1 = new System.Windows.Forms.Label();
            this.textBoxNumber1 = new System.Windows.Forms.TextBox();
            this.labelNumber2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelTextBoxNumber1 = new System.Windows.Forms.Panel();
            this.panelTextBoxNumber2 = new System.Windows.Forms.Panel();
            this.textBoxNumber2 = new System.Windows.Forms.TextBox();
            this.panelTextBoxResult = new System.Windows.Forms.Panel();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.topBar = new PCalc.Controls.TopBar();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panelTextBoxNumber1.SuspendLayout();
            this.panelTextBoxNumber2.SuspendLayout();
            this.panelTextBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNumber1
            // 
            this.labelNumber1.AutoSize = true;
            this.labelNumber1.Location = new System.Drawing.Point(24, 48);
            this.labelNumber1.Name = "labelNumber1";
            this.labelNumber1.Size = new System.Drawing.Size(81, 21);
            this.labelNumber1.TabIndex = 0;
            this.labelNumber1.Text = "Número 1";
            // 
            // textBoxNumber1
            // 
            this.textBoxNumber1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxNumber1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumber1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNumber1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.textBoxNumber1.Location = new System.Drawing.Point(8, 4);
            this.textBoxNumber1.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxNumber1.Name = "textBoxNumber1";
            this.textBoxNumber1.Size = new System.Drawing.Size(144, 22);
            this.textBoxNumber1.TabIndex = 1;
            this.textBoxNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNumber1.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNumber1_Validating);
            // 
            // labelNumber2
            // 
            this.labelNumber2.AutoSize = true;
            this.labelNumber2.Location = new System.Drawing.Point(221, 48);
            this.labelNumber2.Name = "labelNumber2";
            this.labelNumber2.Size = new System.Drawing.Size(81, 21);
            this.labelNumber2.TabIndex = 0;
            this.labelNumber2.Text = "Número 2";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(28, 206);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(47, 47);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
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
            this.buttonClear.Location = new System.Drawing.Point(294, 206);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(91, 47);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Limpar";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // panelTextBoxNumber1
            // 
            this.panelTextBoxNumber1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxNumber1.Controls.Add(this.textBoxNumber1);
            this.panelTextBoxNumber1.Location = new System.Drawing.Point(28, 72);
            this.panelTextBoxNumber1.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxNumber1.Name = "panelTextBoxNumber1";
            this.panelTextBoxNumber1.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxNumber1.Size = new System.Drawing.Size(160, 30);
            this.panelTextBoxNumber1.TabIndex = 1;
            // 
            // panelTextBoxNumber2
            // 
            this.panelTextBoxNumber2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxNumber2.Controls.Add(this.textBoxNumber2);
            this.panelTextBoxNumber2.Location = new System.Drawing.Point(225, 72);
            this.panelTextBoxNumber2.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxNumber2.Name = "panelTextBoxNumber2";
            this.panelTextBoxNumber2.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxNumber2.Size = new System.Drawing.Size(160, 30);
            this.panelTextBoxNumber2.TabIndex = 2;
            // 
            // textBoxNumber2
            // 
            this.textBoxNumber2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxNumber2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumber2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNumber2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.textBoxNumber2.Location = new System.Drawing.Point(8, 4);
            this.textBoxNumber2.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxNumber2.Name = "textBoxNumber2";
            this.textBoxNumber2.Size = new System.Drawing.Size(144, 22);
            this.textBoxNumber2.TabIndex = 2;
            this.textBoxNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNumber2.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNumber2_Validating);
            // 
            // panelTextBoxResult
            // 
            this.panelTextBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxResult.Controls.Add(this.textBoxResult);
            this.panelTextBoxResult.Location = new System.Drawing.Point(28, 146);
            this.panelTextBoxResult.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxResult.Name = "panelTextBoxResult";
            this.panelTextBoxResult.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxResult.Size = new System.Drawing.Size(357, 30);
            this.panelTextBoxResult.TabIndex = 0;
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.textBoxResult.Location = new System.Drawing.Point(8, 4);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(341, 22);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.TabStop = false;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(24, 122);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(79, 21);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Resultado";
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonDivide.FlatAppearance.BorderSize = 0;
            this.buttonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivide.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonDivide.ForeColor = System.Drawing.Color.Black;
            this.buttonDivide.Location = new System.Drawing.Point(217, 206);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(47, 47);
            this.buttonDivide.TabIndex = 6;
            this.buttonDivide.Text = "÷";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonMultiply.FlatAppearance.BorderSize = 0;
            this.buttonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiply.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonMultiply.ForeColor = System.Drawing.Color.Black;
            this.buttonMultiply.Location = new System.Drawing.Point(154, 206);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(47, 47);
            this.buttonMultiply.TabIndex = 5;
            this.buttonMultiply.Text = "×";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonSubtract.FlatAppearance.BorderSize = 0;
            this.buttonSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubtract.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonSubtract.ForeColor = System.Drawing.Color.Black;
            this.buttonSubtract.Location = new System.Drawing.Point(91, 206);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(47, 47);
            this.buttonSubtract.TabIndex = 4;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = false;
            this.buttonSubtract.Click += new System.EventHandler(this.ButtonSubtract_Click);
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.Black;
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Margin = new System.Windows.Forms.Padding(0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(413, 38);
            this.topBar.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(413, 283);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.panelTextBoxResult);
            this.Controls.Add(this.panelTextBoxNumber2);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.panelTextBoxNumber1);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelNumber2);
            this.Controls.Add(this.labelNumber1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volume";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panelTextBoxNumber1.ResumeLayout(false);
            this.panelTextBoxNumber1.PerformLayout();
            this.panelTextBoxNumber2.ResumeLayout(false);
            this.panelTextBoxNumber2.PerformLayout();
            this.panelTextBoxResult.ResumeLayout(false);
            this.panelTextBoxResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber1;
        private System.Windows.Forms.TextBox textBoxNumber1;
        private System.Windows.Forms.Label labelNumber2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panelTextBoxNumber1;
        private System.Windows.Forms.Panel panelTextBoxNumber2;
        private System.Windows.Forms.TextBox textBoxNumber2;
        private System.Windows.Forms.Panel panelTextBoxResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private Controls.TopBar topBar;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
    }
}

