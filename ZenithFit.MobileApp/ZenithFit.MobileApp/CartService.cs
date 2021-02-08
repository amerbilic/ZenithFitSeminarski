using System;
using System.Collections.Generic;
using System.Text;
using ZenithFit.MobileApp.ViewModels;

namespace ZenithFit.MobileApp
{
    public class CartService
    {
        public static Dictionary<int, ArticleDetailsViewModel> Cart = new Dictionary<int, ArticleDetailsViewModel>();
    }
}
