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
    public class CompleteOrderController : BaseCRUDController<Model.CompleteOrder, object, CompleteOrderInsertRequest, CompleteOrderUpdateRequest>
    {
        public CompleteOrderController(ICRUDService<CompleteOrder, object, CompleteOrderInsertRequest, CompleteOrderUpdateRequest> service) : base(service)
        {
        }
    }
}
