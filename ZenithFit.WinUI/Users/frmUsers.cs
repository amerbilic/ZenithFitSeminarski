using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using ZenithFit.Model.Requests;
using ZenithFit.Model;

namespace ZenithFit.WinUI.Users
{
    public partial class frmUsers : Form
    {


        private readonly APIService _apiService = new APIService("Users");
        public frmUsers()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            //Calling the API

            var search = new UsersSearchRequest()
            {
                UserFirstName = txtSearch.Text
            };
            var result = await _apiService.Get<List<Model.Users>>(search);

            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = result;


        }

        private void dgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKorisnici.SelectedRows[0].Cells[0].Value;

            frmUsersDetails frm = new frmUsersDetails(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
