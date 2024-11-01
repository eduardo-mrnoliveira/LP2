namespace PMatriz.Forms
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
            this.buttonExecute = new System.Windows.Forms.Button();
            this.panelListBoxNames = new System.Windows.Forms.Panel();
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelListBoxNames.SuspendLayout();
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
            this.buttonExecute.Location = new System.Drawing.Point(56, 219);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(130, 47);
            this.buttonExecute.TabIndex = 0;
            this.buttonExecute.Text = "Executar";
            this.buttonExecute.UseVisualStyleBackColor = false;
            this.buttonExecute.Click += new System.EventHandler(this.ButtonExecute_Click);
            // 
            // panelListBox
            // 
            this.panelListBoxNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelListBoxNames.Controls.Add(this.listBoxNames);
            this.panelListBoxNames.Location = new System.Drawing.Point(253, 25);
            this.panelListBoxNames.Margin = new System.Windows.Forms.Padding(0);
            this.panelListBoxNames.Name = "panelListBox";
            this.panelListBoxNames.Padding = new System.Windows.Forms.Padding(4);
            this.panelListBoxNames.Size = new System.Drawing.Size(415, 463);
            this.panelListBoxNames.TabIndex = 0;
            // 
            // listBox
            // 
            this.listBoxNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.listBoxNames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.HorizontalScrollbar = true;
            this.listBoxNames.ItemHeight = 21;
            this.listBoxNames.Location = new System.Drawing.Point(4, 4);
            this.listBoxNames.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxNames.Name = "listBox";
            this.listBoxNames.Size = new System.Drawing.Size(407, 455);
            this.listBoxNames.TabIndex = 0;
            this.listBoxNames.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Exercise4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(693, 514);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.panelListBoxNames);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Exercise4Form";
            this.Text = "Exercício 4";
            this.panelListBoxNames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Panel panelListBoxNames;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ListBox listBoxNames;
    }
}