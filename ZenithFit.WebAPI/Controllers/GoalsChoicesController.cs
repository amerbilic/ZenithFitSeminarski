using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model;
using ZenithFit.WebAPI.Services;

namespace ZenithFit.WebAPI.Controllers
{
    public class GoalsChoicesController : BaseCRUDController<Model.GoalsChoices, object, object, object>
    {
        public GoalsChoicesController(ICRUDService<GoalsChoices, object, object, object> service) : base(service)
        {
        }
    }
}
