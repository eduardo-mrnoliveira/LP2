namespace PMatriz.Forms
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
            this.buttonExecute = new System.Windows.Forms.Button();
            this.panelListBoxTestResults = new System.Windows.Forms.Panel();
            this.listBoxTestResults = new System.Windows.Forms.ListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelListBoxTestResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExecute
            // 
            this.buttonExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonExecute.FlatAppearance.BorderSize = 0;
            this.buttonExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExecute.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonExecute.ForeColor = System.Drawing.Color.Black;
            this.buttonExecute.Location = new System.Drawing.Point(47, 220);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(130, 47);
            this.buttonExecute.TabIndex = 1;
            this.buttonExecute.Text = "Executar";
            this.buttonExecute.UseVisualStyleBackColor = false;
            this.buttonExecute.Click += new System.EventHandler(this.ButtonExecute_Click);
            // 
            // panelListBox
            // 
            this.panelListBoxTestResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelListBoxTestResults.Controls.Add(this.listBoxTestResults);
            this.panelListBoxTestResults.Location = new System.Drawing.Point(244, 26);
            this.panelListBoxTestResults.Margin = new System.Windows.Forms.Padding(0);
            this.panelListBoxTestResults.Name = "panelListBox";
            this.panelListBoxTestResults.Padding = new System.Windows.Forms.Padding(4);
            this.panelListBoxTestResults.Size = new System.Drawing.Size(462, 463);
            this.panelListBoxTestResults.TabIndex = 2;
            // 
            // listBox
            // 
            this.listBoxTestResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.listBoxTestResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTestResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTestResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxTestResults.FormattingEnabled = true;
            this.listBoxTestResults.HorizontalScrollbar = true;
            this.listBoxTestResults.ItemHeight = 21;
            this.listBoxTestResults.Location = new System.Drawing.Point(4, 4);
            this.listBoxTestResults.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxTestResults.Name = "listBox";
            this.listBoxTestResults.Size = new System.Drawing.Size(454, 455);
            this.listBoxTestResults.TabIndex = 0;
            this.listBoxTestResults.TabStop = false;
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
            this.ClientSize = new System.Drawing.Size(734, 514);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.panelListBoxTestResults);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Exercise5Form";
            this.Text = "Exercício 5";
            this.panelListBoxTestResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Panel panelListBoxTestResults;
        private System.Windows.Forms.ListBox listBoxTestResults;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}