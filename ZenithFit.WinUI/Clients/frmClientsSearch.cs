using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenithFit.Model;
using ZenithFit.Model.Requests;

namespace ZenithFit.WinUI.Clients
{
    public partial class frmClientsSearch : Form
    {

        private readonly APIService _apiService = new APIService("Clients");

        public frmClientsSearch()
        {
            InitializeComponent();
        }


        private async void btnSearch_Click(object sender, EventArgs e)
        {

            var search = new ClientsSearchRequest()
            {
                ClientName = txtBoxFirstName.Text,
                UserName = txtboxUsername.Text
                
            };

            var result = await _apiService.Get<List<Model.Clients>>(search);
            var returnResult = new List<Model.Clients>();
            foreach(var item in result)
            {
                if(dtpDate.Value <= item.ClientRegisterDate && item.ClientRegisterDate <= dtp2.Value)
                {
                    returnResult.Add(item);
                }
            }

            
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = returnResult;
        }

    }
}
