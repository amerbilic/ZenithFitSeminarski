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
    public partial class OrderHistoryDetailsPage : ContentPage
    {
       
        OrderHistoryDetailsViewModel model = null;
        public OrderHistoryDetailsPage(Model.Orders order)
        {
            InitializeComponent();
            BindingContext = model = new OrderHistoryDetailsViewModel { 
            Order = order};
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }


    }

   
}