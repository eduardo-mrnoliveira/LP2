namespace PContato0030482413057.Forms
{
    partial class ContactsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.dataGridViewContacts = new System.Windows.Forms.DataGridView();
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.labelRegistrationDate = new System.Windows.Forms.Label();
            this.labelCities = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.dateTimePickerRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.bindingNavigatorContacts = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonNew = new System.Windows.Forms.ToolStripButton();
            this.buttonSave = new System.Windows.Forms.ToolStripButton();
            this.buttonUpdate = new System.Windows.Forms.ToolStripButton();
            this.buttonDelete = new System.Windows.Forms.ToolStripButton();
            this.buttonCancel = new System.Windows.Forms.ToolStripButton();
            this.buttonReload = new System.Windows.Forms.ToolStripButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl.SuspendLayout();
            this.tabPageData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).BeginInit();
            this.tabPageDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorContacts)).BeginInit();
            this.bindingNavigatorContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageData);
            this.tabControl.Controls.Add(this.tabPageDetails);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(944, 603);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.dataGridViewContacts);
            this.tabPageData.Location = new System.Drawing.Point(4, 30);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageData.Size = new System.Drawing.Size(936, 569);
            this.tabPageData.TabIndex = 0;
            this.tabPageData.Text = "Dados";
            this.tabPageData.UseVisualStyleBackColor = true;
            // 
            // dataGridViewContacts
            // 
            this.dataGridViewContacts.AllowUserToAddRows = false;
            this.dataGridViewContacts.AllowUserToDeleteRows = false;
            this.dataGridViewContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewContacts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewContacts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewContacts.ColumnHeadersHeight = 38;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewContacts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewContacts.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewContacts.MultiSelect = false;
            this.dataGridViewContacts.Name = "dataGridViewContacts";
            this.dataGridViewContacts.ReadOnly = true;
            this.dataGridViewContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewContacts.Size = new System.Drawing.Size(930, 563);
            this.dataGridViewContacts.TabIndex = 2;
            this.dataGridViewContacts.SelectionChanged += new System.EventHandler(this.DataGridViewContacts_SelectionChanged);
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Controls.Add(this.labelRegistrationDate);
            this.tabPageDetails.Controls.Add(this.labelCities);
            this.tabPageDetails.Controls.Add(this.labelAddress);
            this.tabPageDetails.Controls.Add(this.textBoxAddress);
            this.tabPageDetails.Controls.Add(this.labelPhoneNumber);
            this.tabPageDetails.Controls.Add(this.textBoxPhoneNumber);
            this.tabPageDetails.Controls.Add(this.labelEmail);
            this.tabPageDetails.Controls.Add(this.textBoxEmail);
            this.tabPageDetails.Controls.Add(this.labelName);
            this.tabPageDetails.Controls.Add(this.dateTimePickerRegistrationDate);
            this.tabPageDetails.Controls.Add(this.textBoxName);
            this.tabPageDetails.Controls.Add(this.comboBoxCities);
            this.tabPageDetails.Location = new System.Drawing.Point(4, 30);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetails.Size = new System.Drawing.Size(936, 569);
            this.tabPageDetails.TabIndex = 1;
            this.tabPageDetails.Text = "Detalhes";
            this.tabPageDetails.UseVisualStyleBackColor = true;
            // 
            // labelRegistrationDate
            // 
            this.labelRegistrationDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRegistrationDate.Location = new System.Drawing.Point(175, 384);
            this.labelRegistrationDate.Name = "labelRegistrationDate";
            this.labelRegistrationDate.Size = new System.Drawing.Size(194, 29);
            this.labelRegistrationDate.TabIndex = 11;
            this.labelRegistrationDate.Text = "Data de Cadastro";
            this.labelRegistrationDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCities
            // 
            this.labelCities.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCities.Location = new System.Drawing.Point(175, 338);
            this.labelCities.Name = "labelCities";
            this.labelCities.Size = new System.Drawing.Size(194, 29);
            this.labelCities.TabIndex = 9;
            this.labelCities.Text = "Cidade";
            this.labelCities.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAddress
            // 
            this.labelAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddress.Location = new System.Drawing.Point(175, 294);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(194, 29);
            this.labelAddress.TabIndex = 7;
            this.labelAddress.Text = "Endereço";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAddress.Enabled = false;
            this.textBoxAddress.Location = new System.Drawing.Point(375, 294);
            this.textBoxAddress.MaxLength = 100;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(281, 29);
            this.textBoxAddress.TabIndex = 8;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPhoneNumber.Location = new System.Drawing.Point(175, 245);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(194, 29);
            this.labelPhoneNumber.TabIndex = 5;
            this.labelPhoneNumber.Text = "Nº Celular";
            this.labelPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhoneNumber.Enabled = false;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(375, 245);
            this.textBoxPhoneNumber.MaxLength = 15;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(281, 29);
            this.textBoxPhoneNumber.TabIndex = 6;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmail.Location = new System.Drawing.Point(175, 197);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(194, 29);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Location = new System.Drawing.Point(375, 197);
            this.textBoxEmail.MaxLength = 100;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(281, 29);
            this.textBoxEmail.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.Location = new System.Drawing.Point(175, 151);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(194, 29);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Nome";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePickerRegistrationDate
            // 
            this.dateTimePickerRegistrationDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerRegistrationDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerRegistrationDate.Enabled = false;
            this.dateTimePickerRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerRegistrationDate.Location = new System.Drawing.Point(375, 384);
            this.dateTimePickerRegistrationDate.Name = "dateTimePickerRegistrationDate";
            this.dateTimePickerRegistrationDate.Size = new System.Drawing.Size(281, 29);
            this.dateTimePickerRegistrationDate.TabIndex = 12;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(375, 151);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(281, 29);
            this.textBoxName.TabIndex = 2;
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCities.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCities.Enabled = false;
            this.comboBoxCities.Location = new System.Drawing.Point(375, 339);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(281, 29);
            this.comboBoxCities.TabIndex = 10;
            // 
            // bindingNavigatorContacts
            // 
            this.bindingNavigatorContacts.AddNewItem = null;
            this.bindingNavigatorContacts.AutoSize = false;
            this.bindingNavigatorContacts.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorContacts.DeleteItem = null;
            this.bindingNavigatorContacts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorContacts.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.bindingNavigatorContacts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.buttonNew,
            this.buttonSave,
            this.buttonUpdate,
            this.buttonDelete,
            this.buttonCancel,
            this.buttonReload});
            this.bindingNavigatorContacts.Location = new System.Drawing.Point(4, 607);
            this.bindingNavigatorContacts.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorContacts.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorContacts.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorContacts.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorContacts.Name = "bindingNavigatorContacts";
            this.bindingNavigatorContacts.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorContacts.Size = new System.Drawing.Size(944, 48);
            this.bindingNavigatorContacts.TabIndex = 1;
            this.bindingNavigatorContacts.Text = "bindingNavigatorContacts";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 45);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 45);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 45);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 48);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 45);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 45);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // buttonNew
            // 
            this.buttonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonNew.Image = ((System.Drawing.Image)(resources.GetObject("buttonNew.Image")));
            this.buttonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(36, 45);
            this.buttonNew.Text = "Novo";
            this.buttonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(36, 45);
            this.buttonSave.Text = "Salvar";
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.Image")));
            this.buttonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(36, 45);
            this.buttonUpdate.Text = "Editar";
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(36, 45);
            this.buttonDelete.Text = "Excluir";
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(36, 45);
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonReload.Image = ((System.Drawing.Image)(resources.GetObject("buttonReload.Image")));
            this.buttonReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(36, 45);
            this.buttonReload.Text = "Recarregar";
            this.buttonReload.Click += new System.EventHandler(this.ButtonReload_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(952, 659);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.bindingNavigatorContacts);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "ContactsForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Contatos";
            this.Load += new System.EventHandler(this.ContactsForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).EndInit();
            this.tabPageDetails.ResumeLayout(false);
            this.tabPageDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorContacts)).EndInit();
            this.bindingNavigatorContacts.ResumeLayout(false);
            this.bindingNavigatorContacts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageData;
        private System.Windows.Forms.TabPage tabPageDetails;
        private System.Windows.Forms.BindingNavigator bindingNavigatorContacts;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton buttonNew;
        private System.Windows.Forms.ToolStripButton buttonSave;
        private System.Windows.Forms.ToolStripButton buttonUpdate;
        private System.Windows.Forms.ToolStripButton buttonDelete;
        private System.Windows.Forms.ToolStripButton buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.DataGridView dataGridViewContacts;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegistrationDate;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelRegistrationDate;
        private System.Windows.Forms.Label labelCities;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.ToolStripButton buttonReload;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}