using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZenithFit.MobileApp.Models;

namespace ZenithFit.MobileApp.Views
{
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.Articles:
                        MenuPages.Add(id, new NavigationPage(new ArticlesPage()));
                        break;
                    case (int)MenuItemType.Orders:
                        MenuPages.Add(id, new NavigationPage(new OrdersPage()));
                        break;
                    case (int)MenuItemType.OrderHistory:
                        MenuPages.Add(id, new NavigationPage(new OrderHistoryPage()));
                        break;
                    case (int)MenuItemType.Goals:
                        MenuPages.Add(id, new NavigationPage(new GoalsPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}