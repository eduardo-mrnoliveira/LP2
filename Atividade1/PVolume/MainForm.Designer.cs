namespace PVolume
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
            this.labelRadius = new System.Windows.Forms.Label();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelTextBoxRadius = new System.Windows.Forms.Panel();
            this.panelTextBoxHeight = new System.Windows.Forms.Panel();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.panelTextBoxVolume = new System.Windows.Forms.Panel();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.labelVolume = new System.Windows.Forms.Label();
            this.topBar1 = new PVolume.Controls.TopBar();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panelTextBoxRadius.SuspendLayout();
            this.panelTextBoxHeight.SuspendLayout();
            this.panelTextBoxVolume.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Location = new System.Drawing.Point(24, 48);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(41, 21);
            this.labelRadius.TabIndex = 0;
            this.labelRadius.Text = "Raio";
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxRadius.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRadius.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.textBoxRadius.Location = new System.Drawing.Point(8, 4);
            this.textBoxRadius.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(114, 22);
            this.textBoxRadius.TabIndex = 1;
            this.textBoxRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRadius.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxRadius_Validating);
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
            // panelTextBoxRadius
            // 
            this.panelTextBoxRadius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxRadius.Controls.Add(this.textBoxRadius);
            this.panelTextBoxRadius.Location = new System.Drawing.Point(28, 72);
            this.panelTextBoxRadius.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxRadius.Name = "panelTextBoxRadius";
            this.panelTextBoxRadius.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxRadius.Size = new System.Drawing.Size(130, 30);
            this.panelTextBoxRadius.TabIndex = 1;
            // 
            // panelTextBoxHeight
            // 
            this.panelTextBoxHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxHeight.Controls.Add(this.textBoxHeight);
            this.panelTextBoxHeight.Location = new System.Drawing.Point(188, 72);
            this.panelTextBoxHeight.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxHeight.Name = "panelTextBoxHeight";
            this.panelTextBoxHeight.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxHeight.Size = new System.Drawing.Size(130, 30);
            this.panelTextBoxHeight.TabIndex = 2;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.textBoxHeight.Location = new System.Drawing.Point(8, 4);
            this.textBoxHeight.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(114, 22);
            this.textBoxHeight.TabIndex = 2;
            this.textBoxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHeight.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxHeight_Validating);
            // 
            // panelTextBoxVolume
            // 
            this.panelTextBoxVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelTextBoxVolume.Controls.Add(this.textBoxVolume);
            this.panelTextBoxVolume.Location = new System.Drawing.Point(28, 146);
            this.panelTextBoxVolume.Margin = new System.Windows.Forms.Padding(0);
            this.panelTextBoxVolume.Name = "panelTextBoxVolume";
            this.panelTextBoxVolume.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelTextBoxVolume.Size = new System.Drawing.Size(290, 30);
            this.panelTextBoxVolume.TabIndex = 0;
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textBoxVolume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.textBoxVolume.Location = new System.Drawing.Point(8, 4);
            this.textBoxVolume.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.ReadOnly = true;
            this.textBoxVolume.Size = new System.Drawing.Size(274, 22);
            this.textBoxVolume.TabIndex = 0;
            this.textBoxVolume.TabStop = false;
            this.textBoxVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(24, 122);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(63, 21);
            this.labelVolume.TabIndex = 0;
            this.labelVolume.Text = "Volume";
            // 
            // topBar1
            // 
            this.topBar1.BackColor = System.Drawing.Color.Black;
            this.topBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.topBar1.Location = new System.Drawing.Point(0, 0);
            this.topBar1.Margin = new System.Windows.Forms.Padding(0);
            this.topBar1.Name = "topBar1";
            this.topBar1.Size = new System.Drawing.Size(353, 38);
            this.topBar1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(353, 283);
            this.Controls.Add(this.panelTextBoxVolume);
            this.Controls.Add(this.panelTextBoxHeight);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.panelTextBoxRadius);
            this.Controls.Add(this.topBar1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelRadius);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volume";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panelTextBoxRadius.ResumeLayout(false);
            this.panelTextBoxRadius.PerformLayout();
            this.panelTextBoxHeight.ResumeLayout(false);
            this.panelTextBoxHeight.PerformLayout();
            this.panelTextBoxVolume.ResumeLayout(false);
            this.panelTextBoxVolume.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panelTextBoxRadius;
        private System.Windows.Forms.Panel panelTextBoxHeight;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Panel panelTextBoxVolume;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.Label labelVolume;
        private Controls.TopBar topBar1;
    }
}

