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

namespace ZenithFit.WinUI.Categories
{
    public partial class frmCategories : Form
    {
        private readonly APIService _service = new APIService("Categories");

        public frmCategories()
        {
            InitializeComponent();
        }

        private async void btnCategorySubmit_Click(object sender, EventArgs e)
        {
            var request = new CategoriesInsertRequest()
            {
                CategoryName = txtCategoryName.Text
            };

                await _service.Insert<Model.Categories>(request);

            MessageBox.Show("Success");
        }

        private void txtCategoryName_Validating(object sender, CancelEventArgs e)
        {
           
                if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
                {
                    errorProvider.SetError(txtCategoryName, Properties.Resources.Validation_RequiredField);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtCategoryName, null);
                }
       
        }
    }
}

