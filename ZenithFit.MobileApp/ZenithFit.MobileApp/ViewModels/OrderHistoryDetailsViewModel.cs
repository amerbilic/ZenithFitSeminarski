using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace ZenithFit.MobileApp.ViewModels
{
    public class OrderHistoryDetailsViewModel
    {
        private readonly APIService _service = new APIService("OrderDetails");

        public OrderHistoryDetailsViewModel()
        {

        }

        public Model.Orders Order { get; set; }
        public ObservableCollection<Model.OrderDetails> ObjectList = new ObservableCollection<Model.OrderDetails>();

        public async Task Init()
        {
            var list = await _service.Get<List<Model.OrderDetails>>(null);
            ObjectList.Clear();
            foreach(var item in list)
            {
                if (item.OrderId == Order.OrderId)
                    ObjectList.Add(item);
            }
        }

    }
}
