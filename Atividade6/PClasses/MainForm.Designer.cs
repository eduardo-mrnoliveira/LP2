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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.salariedEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hourlyEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mdiPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salariedEmployeeContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hourlyEmployeeContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleBar = new PClasses.Base.Controls.TitleBar();
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
            this.salariedEmployeeToolStripMenuItem,
            this.hourlyEmployeeToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 38);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(509, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip";
            // 
            // salariedEmployeeToolStripMenuItem
            // 
            this.salariedEmployeeToolStripMenuItem.Name = "salariedEmployeeToolStripMenuItem";
            this.salariedEmployeeToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.salariedEmployeeToolStripMenuItem.Text = "&Mensalista";
            this.salariedEmployeeToolStripMenuItem.Click += new System.EventHandler(this.SalariedEmployeeToolStripMenuItem_Click);
            // 
            // hourlyEmployeeToolStripMenuItem
            // 
            this.hourlyEmployeeToolStripMenuItem.Name = "hourlyEmployeeToolStripMenuItem";
            this.hourlyEmployeeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.hourlyEmployeeToolStripMenuItem.Text = "&Horista";
            this.hourlyEmployeeToolStripMenuItem.Click += new System.EventHandler(this.HourlyEmployeeToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.otherToolStripMenuItem.Text = "&Outros";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.quitToolStripMenuItem.Text = "&Sair";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
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
            this.salariedEmployeeContextMenuItem,
            this.hourlyEmployeeContextMenuItem,
            this.otherContextMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(131, 70);
            // 
            // salariedEmployeeContextMenuItem
            // 
            this.salariedEmployeeContextMenuItem.Name = "salariedEmployeeContextMenuItem";
            this.salariedEmployeeContextMenuItem.Size = new System.Drawing.Size(130, 22);
            this.salariedEmployeeContextMenuItem.Text = "Mensalista";
            this.salariedEmployeeContextMenuItem.Click += new System.EventHandler(this.SalariedEmployeeToolStripMenuItem_Click);
            // 
            // hourlyEmployeeContextMenuItem
            // 
            this.hourlyEmployeeContextMenuItem.Name = "hourlyEmployeeContextMenuItem";
            this.hourlyEmployeeContextMenuItem.Size = new System.Drawing.Size(130, 22);
            this.hourlyEmployeeContextMenuItem.Text = "Horista";
            this.hourlyEmployeeContextMenuItem.Click += new System.EventHandler(this.HourlyEmployeeToolStripMenuItem_Click);
            // 
            // otherContextMenuItem
            // 
            this.otherContextMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitContextMenuItem});
            this.otherContextMenuItem.Name = "otherContextMenuItem";
            this.otherContextMenuItem.Size = new System.Drawing.Size(130, 22);
            this.otherContextMenuItem.Text = "Outros";
            // 
            // quitContextMenuItem
            // 
            this.quitContextMenuItem.Name = "quitContextMenuItem";
            this.quitContextMenuItem.Size = new System.Drawing.Size(93, 22);
            this.quitContextMenuItem.Text = "Sair";
            this.quitContextMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
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
            this.titleBar.TitleBarTitle = "Atividade 6";
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
        private System.Windows.Forms.ToolStripMenuItem salariedEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hourlyEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem salariedEmployeeContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hourlyEmployeeContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitContextMenuItem;
    }
}

