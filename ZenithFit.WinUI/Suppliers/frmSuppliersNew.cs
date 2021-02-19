using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenithFit.Model.Requests;

namespace ZenithFit.WinUI.Suppliers
{
    public partial class frmSuppliersNew : Form
    {
        private readonly APIService _service = new APIService("Suppliers");
        public frmSuppliersNew()
        {
            InitializeComponent();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            SuppliersUpsertRequest item = new SuppliersUpsertRequest();

            item.SupplierEmail = txtEmail.Text;
            item.SupplierAddress = txtAddress.Text;
            item.SupplierBankAccount = txtBankAccount.Text;
            item.SupplierContact = txtContact.Text;
            item.SupplierName = txtName.Text;
            item.SupplierNote = txtNote.Text;
            item.SupplierWeb = txtWeb.Text;
            item.SupplierStatus = true;
            item.SupplierPhone = txtPhone.Text;

            await _service.Insert<Model.Suppliers>(item);

            MessageBox.Show("Supplier successfully added!");
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider.SetError(txtName, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtName, null);
            }
        }

        private void txtContact_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContact.Text))
            {
                errorProvider.SetError(txtContact, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtContact, null);
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProvider.SetError(txtAddress, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtAddress, null);
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider.SetError(txtPhone, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPhone, null);
            }
        }

        private void txtWeb_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtWeb.Text))
            {
                errorProvider.SetError(txtWeb, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtWeb, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtBankAccount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBankAccount.Text))
            {
                errorProvider.SetError(txtBankAccount, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtBankAccount, null);
            }
        }
    }
}
