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
    public class SuppliersController : BaseCRUDController<Model.Suppliers, SuppliersSearchRequest, SuppliersUpsertRequest, SuppliersUpsertRequest>
    {
        public SuppliersController(ICRUDService<Suppliers, SuppliersSearchRequest, SuppliersUpsertRequest, SuppliersUpsertRequest> service) : base(service)
        {
        }
    }
}
