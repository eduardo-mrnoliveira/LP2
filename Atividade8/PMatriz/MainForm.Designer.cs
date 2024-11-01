namespace PMatriz
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.exercise1to3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercise4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercise5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mdiPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exercise1to3ContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercise4ContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercise5ContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleBar = new PMatriz.Base.Controls.TitleBar();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercise1to3ToolStripMenuItem,
            this.exercise4ToolStripMenuItem,
            this.exercise5ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 38);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(509, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip";
            // 
            // exercise1to3ToolStripMenuItem
            // 
            this.exercise1to3ToolStripMenuItem.Name = "exercise1to3ToolStripMenuItem";
            this.exercise1to3ToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.exercise1to3ToolStripMenuItem.Text = "&Exercício 1, 2 e 3";
            this.exercise1to3ToolStripMenuItem.Click += new System.EventHandler(this.Exercise1To3ToolStripMenuItem_Click);
            // 
            // exercise4ToolStripMenuItem
            // 
            this.exercise4ToolStripMenuItem.Name = "exercise4ToolStripMenuItem";
            this.exercise4ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.exercise4ToolStripMenuItem.Text = "Exercício &4";
            this.exercise4ToolStripMenuItem.Click += new System.EventHandler(this.Exercise4ToolStripMenuItem_Click);
            // 
            // exercise5ToolStripMenuItem
            // 
            this.exercise5ToolStripMenuItem.Name = "exercise5ToolStripMenuItem";
            this.exercise5ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.exercise5ToolStripMenuItem.Text = "Exercício &5";
            this.exercise5ToolStripMenuItem.Click += new System.EventHandler(this.Exercise5ToolStripMenuItem_Click);
            // 
            // mdiPanel
            // 
            this.mdiPanel.ContextMenuStrip = this.contextMenuStrip;
            this.mdiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdiPanel.Location = new System.Drawing.Point(0, 62);
            this.mdiPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mdiPanel.Name = "mdiPanel";
            this.mdiPanel.Size = new System.Drawing.Size(509, 440);
            this.mdiPanel.TabIndex = 8;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercise1to3ContextMenuItem,
            this.exercise4ContextMenuItem,
            this.exercise5ContextMenuItem,
            this.quitContextMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(161, 92);
            // 
            // exercise1to3ContextMenuItem
            // 
            this.exercise1to3ContextMenuItem.Name = "exercise1to3ContextMenuItem";
            this.exercise1to3ContextMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exercise1to3ContextMenuItem.Text = "Exercício 1, 2 e 3";
            this.exercise1to3ContextMenuItem.Click += new System.EventHandler(this.Exercise1To3ToolStripMenuItem_Click);
            // 
            // exercise4ContextMenuItem
            // 
            this.exercise4ContextMenuItem.Name = "exercise4ContextMenuItem";
            this.exercise4ContextMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exercise4ContextMenuItem.Text = "Exercício 4";
            this.exercise4ContextMenuItem.Click += new System.EventHandler(this.Exercise4ToolStripMenuItem_Click);
            // 
            // exercise5ContextMenuItem
            // 
            this.exercise5ContextMenuItem.Name = "exercise5ContextMenuItem";
            this.exercise5ContextMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exercise5ContextMenuItem.Text = "Exercício 5";
            // 
            // quitContextMenuItem
            // 
            this.quitContextMenuItem.Name = "quitContextMenuItem";
            this.quitContextMenuItem.Size = new System.Drawing.Size(160, 22);
            this.quitContextMenuItem.Text = "Sair";
            this.quitContextMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Black;
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.titleBar.Size = new System.Drawing.Size(509, 38);
            this.titleBar.TabIndex = 7;
            this.titleBar.TitleBarTitle = "Atividade 8";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(509, 502);
            this.Controls.Add(this.mdiPanel);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.titleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MenuStrip menuStrip;
        private Base.Controls.TitleBar titleBar;
        private System.Windows.Forms.Panel mdiPanel;
        private System.Windows.Forms.ToolStripMenuItem exercise1to3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercise4ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exercise1to3ContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercise4ContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercise5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercise5ContextMenuItem;
    }
}

