using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZenithFit.MobileApp.ViewModels;
using ZenithFit.Model;

namespace ZenithFit.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArticleDetailsPage : ContentPage
    {
        ArticleDetailsViewModel model = null;
        public ArticleDetailsPage(Articles article)
        {
            InitializeComponent();
            BindingContext = model = new ArticleDetailsViewModel() { Article = article };
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (model.Quantity > 0)
            {
                DisplayAlert("Success", "The article has been added to the cart", "OK");
            }
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            await model.Recommender();
        }

        private void recommendedArticlesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}