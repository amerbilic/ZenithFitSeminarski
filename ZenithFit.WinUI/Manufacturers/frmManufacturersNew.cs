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

namespace ZenithFit.WinUI.Manufacturers
{
    public partial class frmManufacturersNew : Form
    {
        private readonly APIService _service = new APIService("Manufacturers");
        public frmManufacturersNew()
        {
            InitializeComponent();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            ManufacturersInsertRequest request = new ManufacturersInsertRequest();
            request.ManufacturerName = txtManufacturerName.Text;

            await _service.Insert<Model.Manufacturers>(request);

        }

        private void txtManufacturerName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtManufacturerName.Text))
            {
                errorProvider.SetError(txtManufacturerName, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtManufacturerName, null);
            }
        }
    }
}
