using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZenithFit.MobileApp.Helpers;
using ZenithFit.MobileApp.ViewModels;
using ZenithFit.Model.Requests;

namespace ZenithFit.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrdersPage : ContentPage
    {
        private decimal Tax = 0.17M;
        private OrdersViewModel model = null;
        private APIService _service = new APIService("Orders");
        public OrdersPage()
        {
            InitializeComponent();
            BindingContext = model = new OrdersViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
        }

        private async void Finish_Clicked(object sender, EventArgs e)
        {
            var orderList = await _service.Get<List<Model.Orders>>(null);

            int highest = int.MinValue;
            foreach (var item in orderList)
            {
                if(item.OrderId > highest)
                {
                    highest = item.OrderId;
                }
            }

            int OrderNumber = highest + 1;

            string value = GenerateOrderNumber.GenerateNumber(OrderNumber);

            OrdersInsertRequest request = new OrdersInsertRequest{
                OrderNumber = value,
                OrderDate = DateTime.Now,
                ClientId = LoggedInUser.ActiveClient.ClientId,
                OrderStatus = true,
                OrderCancelled = false,
                WarehouseId = 1,
                UserId = 1
            };

            foreach (var item in model.OrderList)
            {
                OrderDetailsInsertRequest detail = new OrderDetailsInsertRequest
                {
                    ArticleId = item.Article.ArticleID,
                    Price = item.Article.ArticlePrice,
                    Amount = item.Quantity,
                    Discount = 0
                };

                request.OrderPriceNoTax += detail.Price * detail.Amount;
                request.OrderPriceTax = request.OrderPriceNoTax + request.OrderPriceNoTax * Tax;

                request.Details.Add(detail);
            }

                await _service.Insert<Model.Orders>(request);

                await DisplayAlert("Success", "You have successfully created an order", "OK");
                model.OrderList.Clear();
                CartService.Cart.Clear();
                lblArticleAmount.Text = "Article amount: 0";
                lblValue.Text = "Price: 0 KM";

                await Navigation.PushAsync(new StripePaymentGatewayPage(model.Value));
            }

        }
    }
