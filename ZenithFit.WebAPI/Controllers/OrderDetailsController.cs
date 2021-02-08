using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model;
using ZenithFit.Model.Requests;
using ZenithFit.WebAPI.Services;

namespace ZenithFit.WebAPI.Controllers
{

    public class OrderDetailsController : BaseCRUDController<Model.OrderDetails, object, OrderDetailsInsertRequest, object>
    {
        public OrderDetailsController(ICRUDService<OrderDetails, object, OrderDetailsInsertRequest, object> service) : base(service)
        {
        }
    }
}
