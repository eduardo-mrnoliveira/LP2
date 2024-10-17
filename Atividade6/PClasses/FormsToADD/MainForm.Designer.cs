namespace PClasses
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
            this.labelSide1 = new System.Windows.Forms.Label();
            this.labelSide2 = new System.Windows.Forms.Label();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelTextBoxSide1 = new System.Windows.Forms.Panel();
            this.textBoxSide1 = new System.Windows.Forms.TextBox();
            this.panelTextBoxSide2 = new System.Windows.Forms.Panel();
            this.textBoxSide2 = new System.Windows.Forms.TextBox();
            this.panelTextBoxResult = new System.Windows.Forms.Panel();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelIMC = new System.Windows.Forms.Label();
            this.panelTextBoxSide3 = new System.Windows.Forms.Panel();
            this.textBoxSide3 = new System.Windows.Forms.TextBox();
            this.labelSide3 = new System.Windows.Forms.Label();
            this.topBar = new PClasses.Controls.TopBar();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panelTextBoxSide1.SuspendLayout();
            this.panelTextBoxSide2.SuspendLayout();
            this.panelTextBoxResult.SuspendLayout();
            this.panelTextBoxSide3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSide1
            // 
            this.labelSide1.AutoSize = true;
            this.labelSide1.Location = new System.Drawing.Point(24, 48);
            this.labelSide1.Name = "labelSide1";
            this.labelSide1.Size = new System.Drawing.Size(57, 21);
            this.labelSide1.TabIndex = 0;
            this.labelSide1.Text = "Lado 1";
            // 
            // labelSide2
            // 
            this.labelSide2.AutoSize = true;
            this.labelSide2.Location = new System.Drawing.Point(24, 116);
            this.labelSide2.Name = "labelSide2";
            this.labelSide2.Size = new System.Drawing.Size(57, 21);
            this.labelSide2.TabIndex = 0;
            this.labelSide2.Text = "Lado 2";
            // 
            // buttonValidate
            // 
            this.buttonValidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonValidate.FlatAppearance.BorderSize = 0;
            this.buttonValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValidate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonValidate.ForeColor = System.Drawing.Color.Black;
            this.buttonValidate.Location = new System.Drawing.Point(28, 344);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(130, 47);
            this.buttonValidate.TabIndex = 4;
            this.buttonValidate.Text = "Validar";
            this.buttonValidate.UseVisualStyleBackColor = false;
            this.buttonValidate.Click += new System.EventHandler(this.ButtonCalculate_Click);
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
            this.buttonClear.Location = new System.Drawing.Point(188, 344);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(130, 47);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Limpar";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // panelTextBoxSide1
            // 
            this.panelTextBoxSide1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxSide1.Controls.Add(this.textBoxSide1);
            this.panelTextBoxSide1.Location = new System.Drawing.Point(28, 72);
            this.panelTextBoxSide1.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxSide1.Name = "panelTextBoxSide1";
            this.panelTextBoxSide1.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxSide1.Size = new System.Drawing.Size(290, 30);
            this.panelTextBoxSide1.TabIndex = 1;
            // 
            // textBoxSide1
            // 
            this.textBoxSide1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxSide1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSide1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSide1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxSide1.Location = new System.Drawing.Point(8, 4);
            this.textBoxSide1.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSide1.Name = "textBoxSide1";
            this.textBoxSide1.Size = new System.Drawing.Size(274, 22);
            this.textBoxSide1.TabIndex = 1;
            this.textBoxSide1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSide1.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxSide_Validating);
            // 
            // panelTextBoxSide2
            // 
            this.panelTextBoxSide2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxSide2.Controls.Add(this.textBoxSide2);
            this.panelTextBoxSide2.Location = new System.Drawing.Point(28, 140);
            this.panelTextBoxSide2.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxSide2.Name = "panelTextBoxSide2";
            this.panelTextBoxSide2.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxSide2.Size = new System.Drawing.Size(290, 30);
            this.panelTextBoxSide2.TabIndex = 2;
            // 
            // textBoxSide2
            // 
            this.textBoxSide2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxSide2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSide2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSide2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxSide2.Location = new System.Drawing.Point(8, 4);
            this.textBoxSide2.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSide2.Name = "textBoxSide2";
            this.textBoxSide2.Size = new System.Drawing.Size(274, 22);
            this.textBoxSide2.TabIndex = 2;
            this.textBoxSide2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSide2.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxSide_Validating);
            // 
            // panelTextBoxResult
            // 
            this.panelTextBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxResult.Controls.Add(this.textBoxResult);
            this.panelTextBoxResult.Location = new System.Drawing.Point(28, 289);
            this.panelTextBoxResult.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxResult.Name = "panelTextBoxResult";
            this.panelTextBoxResult.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxResult.Size = new System.Drawing.Size(290, 30);
            this.panelTextBoxResult.TabIndex = 0;
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
            this.textBoxResult.Size = new System.Drawing.Size(274, 22);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.TabStop = false;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelIMC
            // 
            this.labelIMC.AutoSize = true;
            this.labelIMC.Location = new System.Drawing.Point(24, 265);
            this.labelIMC.Name = "labelIMC";
            this.labelIMC.Size = new System.Drawing.Size(79, 21);
            this.labelIMC.TabIndex = 0;
            this.labelIMC.Text = "Resultado";
            // 
            // panelTextBoxSide3
            // 
            this.panelTextBoxSide3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxSide3.Controls.Add(this.textBoxSide3);
            this.panelTextBoxSide3.Location = new System.Drawing.Point(28, 207);
            this.panelTextBoxSide3.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxSide3.Name = "panelTextBoxSide3";
            this.panelTextBoxSide3.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxSide3.Size = new System.Drawing.Size(290, 30);
            this.panelTextBoxSide3.TabIndex = 3;
            // 
            // textBoxSide3
            // 
            this.textBoxSide3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxSide3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSide3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSide3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxSide3.Location = new System.Drawing.Point(8, 4);
            this.textBoxSide3.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSide3.Name = "textBoxSide3";
            this.textBoxSide3.Size = new System.Drawing.Size(274, 22);
            this.textBoxSide3.TabIndex = 3;
            this.textBoxSide3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSide3.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxSide_Validating);
            // 
            // labelSide3
            // 
            this.labelSide3.AutoSize = true;
            this.labelSide3.Location = new System.Drawing.Point(24, 183);
            this.labelSide3.Name = "labelSide3";
            this.labelSide3.Size = new System.Drawing.Size(57, 21);
            this.labelSide3.TabIndex = 0;
            this.labelSide3.Text = "Lado 3";
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
            this.topBar.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(353, 426);
            this.Controls.Add(this.panelTextBoxSide3);
            this.Controls.Add(this.labelSide3);
            this.Controls.Add(this.panelTextBoxResult);
            this.Controls.Add(this.panelTextBoxSide2);
            this.Controls.Add(this.labelIMC);
            this.Controls.Add(this.panelTextBoxSide1);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.labelSide2);
            this.Controls.Add(this.labelSide1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volume";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panelTextBoxSide1.ResumeLayout(false);
            this.panelTextBoxSide1.PerformLayout();
            this.panelTextBoxSide2.ResumeLayout(false);
            this.panelTextBoxSide2.PerformLayout();
            this.panelTextBoxResult.ResumeLayout(false);
            this.panelTextBoxResult.PerformLayout();
            this.panelTextBoxSide3.ResumeLayout(false);
            this.panelTextBoxSide3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSide1;
        private System.Windows.Forms.Label labelSide2;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panelTextBoxSide1;
        private System.Windows.Forms.Panel panelTextBoxSide2;
        private System.Windows.Forms.Panel panelTextBoxResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelIMC;
        private Controls.TopBar topBar;
        private System.Windows.Forms.Panel panelTextBoxSide3;
        private System.Windows.Forms.TextBox textBoxSide3;
        private System.Windows.Forms.Label labelSide3;
        private System.Windows.Forms.TextBox textBoxSide2;
        private System.Windows.Forms.TextBox textBoxSide1;
    }
}

