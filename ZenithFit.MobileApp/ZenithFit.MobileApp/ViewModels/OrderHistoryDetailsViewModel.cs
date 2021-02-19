using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ZenithFit.MobileApp.ViewModels
{
    public class OrderHistoryDetailsViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("OrderDetails");

        public OrderHistoryDetailsViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; private set; }

        public Model.Orders Order { get; set; }
        public ObservableCollection<Model.OrderDetails> OrderList { get; set; } = new ObservableCollection<Model.OrderDetails>();

        public async Task Init()
        {
            var list = await _service.Get<List<Model.OrderDetails>>(null);
            foreach(var item in list)
            {
                if (item.OrderId == Order.OrderId)
                    OrderList.Add(item);
            }
        }

    }
}
