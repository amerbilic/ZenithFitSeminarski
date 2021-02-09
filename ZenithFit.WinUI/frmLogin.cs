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

namespace ZenithFit.WinUI
{
    public partial class frmLogin : Form
    {


        private readonly APIService _service = new APIService("Users");
        private readonly APIService _serviceroles = new APIService("Role");
        Model.Roles admin = null;
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            Model.Users user = await _service.Authenticate<Model.Users>(txtUsername.Text, txtPassword.Text);
            int roleid1 = 0;

            if (user != null)
            {
                Global.LoggedInUser = user;

                foreach (var item in Global.LoggedInUser.UserRoles)
                {
                    roleid1 = item.RoleID;
                }
                admin = await _serviceroles.CheckAdmin<Model.Roles>(roleid1);

                if (admin != null)
                {
                    Global.Admin = true;
                }

                MessageBox.Show("Welcome " + user.UserFirstName + " " + user.UserLastName);
                DialogResult = DialogResult.OK;
                frmIndex frm = new frmIndex();
                frm.Show();
            }

            else
            {
                MessageBox.Show("Wrong username or password", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

