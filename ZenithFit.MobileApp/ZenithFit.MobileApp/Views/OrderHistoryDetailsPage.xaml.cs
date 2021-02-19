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

        private OrderHistoryDetailsViewModel model { get { return BindingContext as OrderHistoryDetailsViewModel; } set { BindingContext = value; } }
        public OrderHistoryDetailsPage(Model.Orders order)
        {
            InitializeComponent();
            model = new OrderHistoryDetailsViewModel { 
            Order = order};
        }

        protected  override void OnAppearing()
        {
            base.OnAppearing();
            model.InitCommand.Execute(null);
        }

    }

   
}