using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZenithFit.MobileApp.ViewModels;

namespace ZenithFit.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConversationPage : ContentPage
    {
        private ConversationViewModel viewModel { get { return BindingContext as ConversationViewModel; } set { BindingContext = value; } }
        public ConversationPage()
        {
            InitializeComponent();
            viewModel = new ConversationViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.InitCommand.Execute(null);
        }


        private void Send_Button_Clicked_1(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(viewModel.MessageText))
            {
                viewModel.InitCommand.Execute(null);
                NewMessage.Text = "";
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Error", "Message must not be empty", "OK");
            }
        }
    }
}