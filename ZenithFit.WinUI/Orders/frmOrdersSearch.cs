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

namespace ZenithFit.WinUI.Orders
{
    public partial class frmOrdersSearch : Form
    {
        private readonly APIService _service = new APIService("Orders");

        public frmOrdersSearch()
        {
            InitializeComponent();
        }

        private void frmOrdersSearch_Load(object sender, EventArgs e)
        {
            var list = _service.Get<List<Model.Orders>>(null);
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.DataSource = list;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new OrdersSearchRequest();
            search.OrderNumber = txtOrderNumber.Text;
            var result = await _service.Get<List<Model.Orders>>(search);

            dgvOrders.DataSource = result;

        }
    }
}
