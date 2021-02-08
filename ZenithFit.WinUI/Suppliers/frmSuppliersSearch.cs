using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZenithFit.WinUI.Suppliers
{
    public partial class frmSuppliersSearch : Form
    {
        private readonly APIService _service = new APIService("Suppliers");
        public  frmSuppliersSearch()
        {
            InitializeComponent();
        }
        private async void frmSuppliersSearch_Load(object sender, EventArgs e)
        {
            var list = await _service.Get<List<Model.Suppliers>>(null);

            dgvSuppliers.DataSource = list;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = await _service.Get<List<Model.Suppliers>>(txtSupplierName.Text);

            dgvSuppliers.DataSource = search;
        }


    }
}
