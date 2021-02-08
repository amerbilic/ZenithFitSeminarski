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


    public class ManufacturersController : BaseCRUDController<Model.Manufacturers, object, Model.Requests.ManufacturersInsertRequest, object>
    {

        public ManufacturersController(ICRUDService<Manufacturers, object, ManufacturersInsertRequest, object> service) : base(service)
        {
        }

    }
}
