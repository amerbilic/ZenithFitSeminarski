using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZenithFit.MobileApp.ViewModels;
using ZenithFit.Model;

namespace ZenithFit.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        RegistrationViewModel model = null;
        APIService _service = new APIService("Clients");

        public RegistrationPage()
        {
            InitializeComponent();
            BindingContext = model = new RegistrationViewModel();

        }

        private async void ButtonRegistration_Clicked(object sender, EventArgs e)
        {
            bool _username = false;
            bool _email = false;

            List<Clients> list = await _service.Get<List<Clients>>(null);

            foreach (var item in list)
            {
                if (item.ClientUsername.Equals(inputUsername.Text) == true)
                {
                    _username = true;
                }
                if (item.ClientEmail.Equals(inputEmail.Text) == true)
                {
                    _email = true;
                }
            }
            if (ValidateRegistration() == true)
            {

                if (_username == true)
                {
                    await DisplayAlert("Error", "That username is already in use!", "OK");
                    usernameError.Text = "Username already exists!";
                    usernameError.IsVisible = true;
                }
                else if (_email == true)
                {
                    await DisplayAlert("Error", "That email is already in use!", "OK");
                    emailError.Text = "Email already in use!";
                    emailError.IsVisible = true;
                }
                else
                {
                    await model.Registration();
                }

            }
            else
            {
                await DisplayAlert("Error", "Faulty input", "OK");

            }

        }

        private bool ValidateRegistration()
        {
            bool valid = true;
            if (ValidateName() == false || ValidateLastName() == false || ValidateEmail() == false || ValidatePhone() == false || ValidateUsername() == false || ValidatePassword() == false || ValidateConfirmPassword() == false)
                valid = false;

            if (valid == false)
            {
                return false;
            }
            else
            {
                return true;
            };
        }
        private bool ValidateName()
        {
            if (string.IsNullOrWhiteSpace(inputName.Text))
            {

                nameError.Text = "This is a required field!";
                nameError.IsVisible = true;
                return false;
            }
            else
            {

                nameError.IsVisible = false;
                nameError.Text = "";
                return true;
            }
        }

        private bool ValidateLastName()
        {
            if (string.IsNullOrWhiteSpace(inputLastName.Text))
            {
                inputLastName.Text = "This is a required field!";
                inputLastName.IsVisible = true;
                return false;
            }
            else
            {

                lastNameError.IsVisible = false;
                lastNameError.Text = "";
                return true;
            }
        }
        private bool ValidatePhone()
        {
            if (string.IsNullOrWhiteSpace(inputPhone.Text))
            {
                inputPhone.Text = "This is a required field!";
                inputPhone.IsVisible = true;
                return false;
            }
            else
            {

                phoneError.IsVisible = false;
                phoneError.Text = "";
                return true;
            }
        }
        private bool ValidateEmail()
        {
            try
            {
                MailAddress mail = new MailAddress(inputEmail.Text);

            }
            catch (Exception)
            {
                emailError.Text = "That is not a valid Email!";
                emailError.IsVisible = true;
                return false;
            }

            if (string.IsNullOrWhiteSpace(inputEmail.Text))
            {

                emailError.Text = "This is a required field!";
                emailError.IsVisible = true;
                return false;
            }
            else
            {

                emailError.IsVisible = false;
                emailError.Text = "";
                return true;
            }

        }

        private bool ValidateUsername()
        {
            if (string.IsNullOrWhiteSpace(inputUsername.Text))
            {
                inputUsername.Text = "This is a required field!";
                inputUsername.IsVisible = true;
                return false;
            }
            if (inputUsername.Text.Count() < 6)
            {
                inputUsername.Text = "Username must be longer than six characters!";
                inputUsername.IsVisible = true;
                return false;
            }
            else
            {

                usernameError.IsVisible = false;
                usernameError.Text = "";
                return true;
            }
        }

        private bool ValidatePassword()
        {
            if (string.IsNullOrWhiteSpace(inputPassword.Text))
            {

                passwordError.Text = "This is a required field!";
                passwordError.IsVisible = true;
                return false;
            }
            if (inputPassword.Text.Count() < 6)
            {

                passwordError.Text = "Password needs to be longer than six characters!";
                passwordError.IsVisible = true;
                return false;
            }
            if (inputPassword.Text == inputUsername.Text)
            {

                passwordError.Text = "Cannot use your username as a password!";
                passwordError.IsVisible = true;
                return false;
            }
            else
            {

                passwordError.IsVisible = false;
                passwordError.Text = "";
                return true;
            }
        }
        private bool ValidateConfirmPassword()
        {
            if (inputPassword.Text != inputConfirmation.Text)
            {

                confirmationError.Text = "Passwords do not match!";
                confirmationError.IsVisible = true;
                return false;
            }
            else
            {
                confirmationError.Text = "";
                confirmationError.IsVisible = false;
                return true;
            }
        }


    }

}