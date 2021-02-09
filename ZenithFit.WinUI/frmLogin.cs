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
        private readonly APIService _serviceroles = new APIService("UserRoles");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;

                UserLoginRequest newLogin = new UserLoginRequest { Password = txtPassword.Text, Username = txtUsername.Text };

                var temp = await _service.Authenticate<Model.Users>(newLogin);

                    //this.Hide();
                    frmIndex frm = new frmIndex();
                    frm.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /* APIService.Username = txtUsername.Text;
             APIService.Password = txtPassword.Text;

             await _service.Get<dynamic>(null);

             frmIndex frm = new frmIndex();
             frm.Show();

         }
         catch(Exception ex)
         {
             MessageBox.Show(ex.Message, "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }*/


        }
    }
}

