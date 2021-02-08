using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZenithFit.MobileApp.Models;
using ZenithFit.MobileApp.ViewModels;

namespace ZenithFit.MobileApp.Views
{

    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel = null;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
        }



        protected override void OnAppearing()
        {
            base.OnAppearing();
           // await viewModel.Init();
        }
    }
}