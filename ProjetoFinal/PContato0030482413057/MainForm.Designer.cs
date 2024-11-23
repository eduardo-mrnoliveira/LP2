namespace PContato0030482413057
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contactsContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiFormContainer = new PContato0030482413057.Base.Controls.MultiFormContainer();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(813, 29);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip";
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.contactsToolStripMenuItem.Text = "&Contatos";
            this.contactsToolStripMenuItem.Click += new System.EventHandler(this.ContactsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.aboutToolStripMenuItem.Text = "&Sobre";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(51, 25);
            this.quitToolStripMenuItem.Text = "Sair";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactsContextMenuItem,
            this.aboutContextMenuItem,
            this.quitContextMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(123, 70);
            // 
            // contactsContextMenuItem
            // 
            this.contactsContextMenuItem.Name = "contactsContextMenuItem";
            this.contactsContextMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contactsContextMenuItem.Text = "Contatos";
            this.contactsContextMenuItem.Click += new System.EventHandler(this.ContactsToolStripMenuItem_Click);
            // 
            // aboutContextMenuItem
            // 
            this.aboutContextMenuItem.Name = "aboutContextMenuItem";
            this.aboutContextMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutContextMenuItem.Text = "Sobre";
            this.aboutContextMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // quitContextMenuItem
            // 
            this.quitContextMenuItem.Name = "quitContextMenuItem";
            this.quitContextMenuItem.Size = new System.Drawing.Size(122, 22);
            this.quitContextMenuItem.Text = "Sair";
            this.quitContextMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // multiFormContainer
            // 
            this.multiFormContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.multiFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiFormContainer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.multiFormContainer.ForeColor = System.Drawing.Color.Black;
            this.multiFormContainer.Location = new System.Drawing.Point(0, 29);
            this.multiFormContainer.Margin = new System.Windows.Forms.Padding(0);
            this.multiFormContainer.Name = "multiFormContainer";
            this.multiFormContainer.Size = new System.Drawing.Size(813, 473);
            this.multiFormContainer.TabIndex = 0;
            this.multiFormContainer.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(813, 502);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.multiFormContainer);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto Final";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem contactsContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private Base.Controls.MultiFormContainer multiFormContainer;
    }
}

