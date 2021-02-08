using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;
using System.Linq;

namespace ZenithFit.MobileApp.ViewModels
{
    public class OrdersViewModel : BaseViewModel
    {
        public ObservableCollection<ArticleDetailsViewModel> OrderList { get; set; } = new ObservableCollection<ArticleDetailsViewModel>();

        decimal _articleAmount = 0;

        public decimal ArticleAmount
        {
            get { return _articleAmount; }
            set { SetProperty(ref _articleAmount, value); }
        }

        decimal _value = 0;
        public decimal Value
        {
            get { return _value; }
            set { SetProperty(ref _value, value); }
        }

        public void Init()
        {
            foreach (var item in CartService.Cart.Values)
            {
                OrderList.Add(item);
            }

            Value = 0;
            foreach(var item in OrderList)
            {
                Value += item.Article.ArticlePrice * item.Quantity;
            }
            ArticleAmount = OrderList.Count();

            CartService.Cart.Clear();
        }
    }
}
