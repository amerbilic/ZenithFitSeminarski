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
    public partial class frmWarehousesSearch : Form
    {

        APIService _service = new APIService("Warehouses");
        public frmWarehousesSearch()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new WarehousesSearchRequest()
            {
                WarehouseName = txtWarehouseName.Text,
                WarehouseAddress = txtWarehouseAddress.Text
            };

            var result = await _service.Get<List<Model.Warehouses>>(search);
            dgvWarehouses.DataSource = result;
        }
    }
}
