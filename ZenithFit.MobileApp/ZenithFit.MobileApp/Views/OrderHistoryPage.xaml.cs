using System;
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
    public partial class OrderHistoryPage : ContentPage
    {
        OrderHistoryViewModel model = null;
        public OrderHistoryPage()
        {
            InitializeComponent();

            BindingContext = model = new OrderHistoryViewModel();
        }

        protected async override void OnAppearing()
        {

            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.Orders;

            await Navigation.PushAsync(new OrderHistoryDetailsPage(item));
        }
    }
}