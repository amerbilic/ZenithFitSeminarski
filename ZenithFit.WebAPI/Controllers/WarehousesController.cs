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
    public class WarehousesController : BaseCRUDController<Model.Warehouses, WarehousesSearchRequest, Model.Requests.WarehousesInsertRequest, object>
    {
        public WarehousesController(ICRUDService<Warehouses, WarehousesSearchRequest, WarehousesInsertRequest, object> service) : base(service)
        {
        }
    }
}
