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

namespace ZenithFit.WinUI.Users
{
    public partial class frmUsersDetails : Form
    {
        
        private readonly APIService _service = new APIService("Users");
        private readonly APIService _serviceRoles = new APIService("Roles");
        private int? _id = null;
        public frmUsersDetails(int? UserID = null)
        {
            InitializeComponent();
            _id = UserID;
        }

         private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new UsersInsertRequest()
                {
                    UserEmail = txtUserEmail.Text,
                    UserFirstName = txtUserFirstName.Text,
                    UserLastName = txtUserLastName.Text,
                    UserPhone = txtUserPhone.Text,
                    UserUsername = txtUsername.Text,
                    Password = txtPassword.Text,
                    PasswordConfirmation = txtConfirmPassword.Text
                };

                if (_id.HasValue)
                {
                    await _service.Update<Model.Users>(_id, request);
                }
                else
                {
                    await _service.Insert<Model.Users>(request);
                }

                MessageBox.Show("Success");
            }
      
        }

        private async void frmUsersDetails_LoadAsync(object sender, EventArgs e)
        {
            var roles = _serviceRoles.Get<List<Model.Roles>>(null);
            clbRoles.DisplayMember = "RoleName";
            clbRoles.DataSource = roles;
            if(_id.HasValue)
            {
                var user = await _service.GetbyId<Model.Users>(_id);

                txtUserFirstName.Text = user.UserEmail;
                txtUserLastName.Text = user.UserLastName;
                txtUserEmail.Text = user.UserEmail;
                txtUsername.Text = user.UserUsername;
                
            }
        }

        private void txtUserFirstName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtUserFirstName.Text))
            {
                errorProvider.SetError(txtUserFirstName, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtUserFirstName, null);
            }

        }

        private void txtUserLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserLastName.Text))
            {
                errorProvider.SetError(txtUserLastName, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtUserLastName, null);
            }
        }
    }
}
