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

namespace ZenithFit.WinUI.Warehouses
{
    public partial class frmWarehousesNew : Form
    {
        APIService _service = new APIService("Warehouses");
        private int? _id = null;
        public frmWarehousesNew(int? id=null)
        {
            _id = id;
            InitializeComponent();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            var request = new WarehousesInsertRequest()
            {
                WarehouseName = txtName.Text,
                WarehouseAddress = txtAddress.Text,
                WarehouseNote = txtNote.Text
            };

            await _service.Insert<Model.Warehouses>(request);
            MessageBox.Show("The warehouse has been added succesfully!");
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
    }
}
