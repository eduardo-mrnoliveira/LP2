using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PContato0030482413057.Models;
using PContato0030482413057.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PContato0030482413057.Forms
{
    public partial class ContactsForm : Form
    {
        private const string CONNECTION_STRING =
            "Server=localhost; Database=LP2; User Id=BD2413057; Password=--my@SQL; TrustServerCertificate=True;";

        private readonly CitiesRepository _citiesRepository;
        private readonly ContactsRepository _contactsRepository;

        private readonly BindingSource _contactsBindingSource = new BindingSource();

        private DataTable _citiesDataTable;
        private DataTable _contactsDataTable;

        private DataRowView _newRegister = null;
        private DataRowView _editingRegister = null;

        public ContactsForm()
        {
            InitializeComponent();

            this._citiesRepository = new CitiesRepository(CONNECTION_STRING);
            this._contactsRepository = new ContactsRepository(CONNECTION_STRING);

            this.bindingNavigatorContacts.BindingSource = this._contactsBindingSource;
            this.dataGridViewContacts.DataSource = this._contactsBindingSource;

            // Buttons state

            this.ButtonsDefaultState();

            // Inputs state

            this.DisableInputs();
        }

        public void ButtonsDefaultState()
        {
            this.buttonNew.Enabled = true;
            this.buttonSave.Enabled = false;
            this.buttonUpdate.Enabled = true;
            this.buttonDelete.Enabled = true;
            this.buttonCancel.Enabled = false;
        }

        public void ButtonsEditingState()
        {
            this.buttonNew.Enabled = false;
            this.buttonSave.Enabled = true;
            this.buttonUpdate.Enabled = false;
            this.buttonDelete.Enabled = false;
            this.buttonCancel.Enabled = true;
        }

        private void DisableInputs()
        {
            this.textBoxName.Enabled = false;
            this.textBoxEmail.Enabled = false;
            this.textBoxPhoneNumber.Enabled = false;
            this.textBoxAddress.Enabled = false;
            this.comboBoxCities.Enabled = false;
            this.dateTimePickerRegistrationDate.Enabled = false;
        }

        private void EnableInputs()
        {
            this.textBoxName.Enabled = true;
            this.textBoxEmail.Enabled = true;
            this.textBoxPhoneNumber.Enabled = true;
            this.textBoxAddress.Enabled = true;
            this.comboBoxCities.Enabled = true;
            this.dateTimePickerRegistrationDate.Enabled = true;
        }

        private DialogResult TryAgainErrorMessage(string message)
        {
            return MessageBox.Show(
                this, message, "Projeto Final - Erro",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1
            );
        }

        private void ErrorMessage(string message)
        {
            MessageBox.Show(
                this, message, "Projeto Final - Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1
            );
        }

        private DialogResult ConfirmationMessage(string message)
        {
            return MessageBox.Show(
                this, message, "Projeto Final - Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );
        }

        private void SucessMessage(string message)
        {
            MessageBox.Show(
                this, message, "Projeto Final - Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
            );
        }

        private bool LoadCities()
        {
            while (true)
            {
                try
                {
                    this._citiesDataTable =
                        this._citiesRepository.GetAll();

                    break;
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception.Message);

                    var dialogResult = this.TryAgainErrorMessage(
                        "Não foi possível carregar as cidades!\n\nTentar novamente?"
                    );

                    if (dialogResult == DialogResult.Cancel)
                    {
                        return false;
                    }
                }
            }

            if (this._citiesDataTable == null) return false;

            this._citiesDataTable.Columns // Cidade - UF
                .Add("NameWithFederativeUnit", typeof(string), "Name + ' - ' + FederativeUnit");

            var current = this._contactsBindingSource.Current as DataRowView;

            this.comboBoxCities.DataSource = this._citiesDataTable;
            this.comboBoxCities.DisplayMember = "NameWithFederativeUnit";
            this.comboBoxCities.ValueMember = "Id";
            this.comboBoxCities.SelectedValue = current["CityId"];

            return true;
        }

        private bool LoadContacts()
        {
            while (true)
            {
                try
                {
                    this._contactsDataTable =
                        this._contactsRepository.GetAll();

                    break;
                }
                catch (Exception excepction)
                {
                    Debug.WriteLine(excepction.Message);

                    var dialogResult = this.TryAgainErrorMessage(
                        "Não foi possível carregar seus contatos!\n\nTentar novamente?"
                    );

                    if (dialogResult == DialogResult.Cancel)
                    {
                        return false;
                    }
                }
            }

            if (this._contactsDataTable == null) return false;

            this._contactsBindingSource.DataSource = this._contactsDataTable;

            // Hiding columns

            this.dataGridViewContacts
                .Columns["Id"].Visible = false;
            this.dataGridViewContacts
                .Columns["CityId"].Visible = false;

            // Renaming headers displayed text

            this.dataGridViewContacts
                .Columns["Name"].HeaderText = "Nome";
            this.dataGridViewContacts
                .Columns["Address"].HeaderText = "Endereço";
            this.dataGridViewContacts
                .Columns["PhoneNumber"].HeaderText = "Nº Celular";
            this.dataGridViewContacts
                .Columns["Email"].HeaderText = "Email";
            this.dataGridViewContacts
                .Columns["RegistrationDate"].HeaderText = "Data de Registro";
            this.dataGridViewContacts
                .Columns["CityName"].HeaderText = "Cidade";
            this.dataGridViewContacts
                .Columns["CityFederativeUnit"].HeaderText = "UF";

            // Data bindings

            this.textBoxName.DataBindings.Clear();
            this.textBoxAddress.DataBindings.Clear();
            this.textBoxEmail.DataBindings.Clear();
            this.textBoxPhoneNumber.DataBindings.Clear();
            this.textBoxAddress.DataBindings.Clear();
            this.comboBoxCities.DataBindings.Clear();
            this.dateTimePickerRegistrationDate.DataBindings.Clear();

            this.textBoxName.DataBindings
                .Add("TEXT", this._contactsBindingSource, "Name");

            this.textBoxEmail.DataBindings
                .Add("TEXT", this._contactsBindingSource, "Email");

            this.textBoxPhoneNumber.DataBindings
                .Add("TEXT", this._contactsBindingSource, "PhoneNumber");

            this.textBoxAddress.DataBindings
                .Add("TEXT", this._contactsBindingSource, "Address");

            this.comboBoxCities.DataBindings
                .Add("SelectedValue", this._contactsBindingSource, "CityId");

            this.dateTimePickerRegistrationDate.DataBindings
                .Add("TEXT", this._contactsBindingSource, "RegistrationDate");

            return true;
        }

        private bool LoadData(bool forceReload = false)
        {
            this.Cursor = Cursors.WaitCursor;

            if (this._contactsDataTable == null || forceReload)
            {
                bool loaded = this.LoadContacts();

                if (!loaded)
                {
                    this.Cursor = Cursors.Default;
                    return false;
                }
            }

            if (this._citiesDataTable == null || forceReload)
            {
                bool loaded = this.LoadCities();

                if (!loaded)
                {
                    this.Cursor = Cursors.Default;
                    return false;
                }
            }

            this.Cursor = Cursors.Default;
            return true;
        }

        private void ContactsForm_Load(object sender, EventArgs e)
        {
            this.errorProvider.SetIconPadding(this.textBoxName, -32);
            this.errorProvider.SetIconPadding(this.textBoxEmail, -32);
            this.errorProvider.SetIconPadding(this.textBoxPhoneNumber, -32);
            this.errorProvider.SetIconPadding(this.textBoxAddress, -32);
            this.errorProvider.SetIconPadding(this.comboBoxCities, -32);

            this.LoadData(true);
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            if (this.tabControl.SelectedTab == this.tabPageData)
            {
                this.tabControl.SelectTab(this.tabPageDetails);
            }

            if (!this.LoadData()) return;

            this._newRegister = this._contactsBindingSource.AddNew() as DataRowView;

            // Set default values

            this._newRegister["Id"] = -1;
            this._newRegister["Name"] = "";
            this._newRegister["Address"] = "";
            this._newRegister["PhoneNumber"] = "";
            this._newRegister["Email"] = "";
            this._newRegister["RegistrationDate"] = DateTime.Now;
            this._newRegister["CityId"] = -1;
            this._newRegister["CityName"] = "";
            this._newRegister["CityFederativeUnit"] = "";
            this.comboBoxCities.SelectedIndex = -1;

            this.EnableInputs();

            this.ButtonsEditingState();

            this._editingRegister = null;
        }

        private bool ValidateInputs()
        {
            bool valid = true;

            if (this.textBoxName.Text == "")
            {
                this.errorProvider.SetError(this.textBoxName, "Nome inválido!");
                valid = false;
            }
            else
            {
                this.errorProvider.SetError(this.textBoxName, "");
            }

            if (this.textBoxAddress.Text == "")
            {
                this.errorProvider.SetError(this.textBoxAddress, "Endereço inválido!");
                valid = false;
            }
            else
            {
                this.errorProvider.SetError(this.textBoxAddress, "");
            }

            if (this.textBoxPhoneNumber.Text == "")
            {
                this.errorProvider.SetError(this.textBoxPhoneNumber, "N° de celular inválido!");
                valid = false;
            }
            else
            {
                this.errorProvider.SetError(this.textBoxPhoneNumber, "");
            }

            if (this.textBoxEmail.Text == "")
            {
                this.errorProvider.SetError(this.textBoxEmail, "Email inválido!");
                valid = false;
            }
            else
            {
                this.errorProvider.SetError(this.textBoxEmail, "");
            }

            if (this.comboBoxCities.SelectedIndex == -1)
            {
                this.errorProvider.SetError(this.comboBoxCities, "Cidade inválida!");
                valid = false;
            }
            else
            {
                this.errorProvider.SetError(this.comboBoxCities, "");
            }

            return valid;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateInputs()) return;

            var current = this._contactsBindingSource.Current as DataRowView;

            Contact contact = new Contact()
            {
                Id = (int)current["Id"],

                Name = this.textBoxName.Text,
                Address = this.textBoxAddress.Text,
                PhoneNumber = this.textBoxPhoneNumber.Text,
                Email = this.textBoxEmail.Text,
                RegistrationDate = this.dateTimePickerRegistrationDate.Value,

                CityId = int.Parse(this.comboBoxCities.SelectedValue.ToString())
            };

            if (this._newRegister != null)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    int insertId = this._contactsRepository.Save(contact);
                    this.Cursor = Cursors.Default;

                    this.DisableInputs();

                    this.ButtonsDefaultState();

                    this.SucessMessage(
                        "Contato salvo com sucesso!"
                    );

                    this.Cursor = Cursors.WaitCursor;
                    bool loaded = this.LoadContacts();
                    this.Cursor = Cursors.Default;

                    // Reselect the new register

                    if (loaded)
                    {
                        int rowIndex =
                            this._contactsBindingSource.Find("Id", insertId);

                        if (rowIndex != -1)
                        {
                            this._contactsBindingSource.Position = rowIndex;
                        }
                    }

                    // Clear new register

                    this._newRegister = null;
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception.Message);

                    this.ErrorMessage(
                        "Não foi possível salvar o contato!"
                    );
                }
            }
            else
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    int affectedRows = this._contactsRepository.Update(contact);
                    this.Cursor = Cursors.Default;

                    if (affectedRows <= 0)
                    {
                        this.ErrorMessage(
                            "Não foi possível salvar o contato!"
                        );
                        return;
                    }

                    this.DisableInputs();

                    this.ButtonsDefaultState();

                    this.SucessMessage(
                        "Contato alterado com sucesso!"
                    );

                    this.Cursor = Cursors.WaitCursor;
                    bool loaded = this.LoadContacts();
                    this.Cursor = Cursors.Default;

                    // Reselect the updated register

                    if (loaded)
                    {
                        int rowIndex =
                            this._contactsBindingSource.Find("Id", contact.Id);

                        if (rowIndex != -1)
                        {
                            this._contactsBindingSource.Position = rowIndex;
                        }
                    }

                    // Clear new register

                    this._editingRegister = null;
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception.Message);

                    this.ErrorMessage(
                        "Não foi possível alterar o contato!"
                    );
                }
            }

            this.Cursor = Cursors.Default; // Reset any loading
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (this.tabControl.SelectedTab == this.tabPageData)
            {
                this.tabControl.SelectTab(this.tabPageDetails);
            }

            if (!this.LoadData()) return;

            this._editingRegister = this._contactsBindingSource.Current as DataRowView;

            this.EnableInputs();

            this.ButtonsEditingState();

            this._newRegister = null;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (this.tabControl.SelectedTab == this.tabPageData)
            {
                this.tabControl.SelectTab(this.tabPageDetails);
            }

            if (!this.LoadData()) return;

            var current = this._contactsBindingSource.Current as DataRowView;

            Contact contact = new Contact()
            {
                Id = (int)current["Id"]
            };

            DialogResult dialogResult = this.ConfirmationMessage(
                "Você realmente deseja excluir este contato?"
            );

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    int affectedRows = this._contactsRepository.Delete(contact);
                    this.Cursor = Cursors.Default;

                    if (affectedRows <= 0)
                    {
                        this.ErrorMessage(
                            "Não foi possível excluir o contato!"
                        );
                        return;
                    }

                    this.SucessMessage(
                        "Contato excluído com sucesso!"
                    );

                    this.Cursor = Cursors.WaitCursor;
                    this.LoadContacts();
                    this.Cursor = Cursors.Default;
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception.Message);

                    this.ErrorMessage(
                        "Não foi possível excluir o contato!"
                    );
                }
            }

            this.Cursor = Cursors.Default; // Reset any loading
        }

        private void Cancel()
        {
            this.ButtonsDefaultState();

            this.DisableInputs();

            if (this._contactsBindingSource.Contains(this._newRegister))
            {
                this._contactsBindingSource.Remove(this._newRegister);
            }

            if (this._contactsBindingSource.Contains(this._editingRegister))
            {
                this.Cursor = Cursors.WaitCursor;
                this.LoadContacts();
                this.Cursor = Cursors.Default;
            }

            this._newRegister = null;
            this._editingRegister = null;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Cancel();
        }

        private void ButtonReload_Click(object sender, EventArgs e)
        {
            this.Cancel();

            this.LoadData(true);
        }

        private void DataGridViewContacts_SelectionChanged(object sender, EventArgs e)
        {
            if (
                this._newRegister != null &&
                this._newRegister != this._contactsBindingSource.Current
            )
            {
                this.Cancel();
            }

            if (
                this._editingRegister != null &&
                this._editingRegister != this._contactsBindingSource.Current
            )
            {
                this.Cancel();
            }
        }
    }
}
