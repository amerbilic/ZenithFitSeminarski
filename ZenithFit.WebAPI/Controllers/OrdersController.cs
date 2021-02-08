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
    public class OrdersController : BaseCRUDController<Model.Orders, OrdersSearchRequest, OrdersInsertRequest, object>
    {
        public OrdersController(ICRUDService<Orders, OrdersSearchRequest, OrdersInsertRequest, object> service) : base(service)
        {
        }
    }
}
