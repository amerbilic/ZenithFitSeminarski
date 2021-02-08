using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ZenithFit.Model.Requests;
using Xamarin.Forms;

namespace ZenithFit.MobileApp.ViewModels
{
    public class RegistrationViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Clients");
        public RegistrationViewModel()
        {

        }

        string _name = string.Empty;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
        string _lastname = string.Empty;
        public string LastName
        {
            get { return _lastname; }
            set { SetProperty(ref _lastname, value); }
        }
        string _email = string.Empty;

        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
        string _phone = string.Empty;
        public string Phone
        {
            get { return _phone; }
            set { SetProperty(ref _phone, value); }
        }
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        string _confirmation = string.Empty;
        public string Confirmation
        {
            get { return _confirmation; }
            set { SetProperty(ref _confirmation, value); }
        }

        public async Task Registration()
        {
            ClientsInsertRequest request = new ClientsInsertRequest
            {
                ClientRegisterDate = DateTime.Now,
                ClientFirstName = Name,
                ClientLastName = LastName,
                ClientPhone = Phone,
                ClientEmail = Email,
                ClientUsername = Username,
                Password = Password,
                PasswordConfirmation = Confirmation
            };

            await _service.Insert<Model.Clients>(request);

            await Application.Current.MainPage.Navigation.PopAsync();
            await Application.Current.MainPage.DisplayAlert("Success", "You have registered succesfully", "OK");
        }
    }
}
