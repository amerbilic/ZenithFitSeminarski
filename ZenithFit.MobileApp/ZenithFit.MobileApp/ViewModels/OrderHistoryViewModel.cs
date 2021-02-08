using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ZenithFit.MobileApp.ViewModels
{
    public class OrderHistoryViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Orders");

        public OrderHistoryViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Model.Orders> OrderList = new ObservableCollection<Model.Orders>();

        public ICommand InitCommand;

        public async Task Init()
        {
            List<Model.Orders> list = await _service.Get<List<Model.Orders>>(null);
            OrderList.Clear();

            foreach (var item in list)
            {
                if(item.ClientId == LoggedInUser.ActiveClient.ClientId)
                {
                    OrderList.Add(item);
                }
            }

        }

    }
}
