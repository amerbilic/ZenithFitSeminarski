using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZenithFit.WinUI.Manufacturers
{
    public partial class frmManufacturersSearch : Form
    {
        private readonly APIService _service = new APIService("Manufacturers");
        public frmManufacturersSearch()
        {
            InitializeComponent();
        }

        private async void frmManufacturersSearch_Load(object sender, EventArgs e)
        {
            var list = await _service.Get<List<Model.Manufacturers>>(null);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = list;
        }
    }
}
