using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model;
using ZenithFit.WebAPI.Services;

namespace ZenithFit.WebAPI.Controllers
{
    public class RolesController : BaseController<Model.Roles, object>
    {
        public RolesController(IService<Roles, object> service) : base(service)
        {
        }

    }
}
