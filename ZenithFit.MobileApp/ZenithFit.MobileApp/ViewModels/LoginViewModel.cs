using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ZenithFit.MobileApp.Views;

namespace ZenithFit.MobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Clients");
        
        public LoginViewModel()
        {
             LoginCommand = new Command(async () => await Login());
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

        public ICommand LoginCommand { get; set; }

        async Task Login()
        {
            IsBusy = true;


                APIService.Username = Username;
                APIService.Password = Password;
                Model.Clients client = await _service.Login<Model.Clients>(Username, Password);

                if (client != null)
                {
                     LoggedInUser.ActiveClient = client;

                    await Application.Current.MainPage.DisplayAlert("Success", "Welcome " + client.ClientFirstName + " " + client.ClientLastName, "OK");
                    Application.Current.MainPage = new MainPage();
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Wrong username or password", "OK");
                }
            }
            }

        }

    
