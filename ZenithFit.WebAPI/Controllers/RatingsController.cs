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
    public class RatingsController : BaseCRUDController<Model.Ratings, object, Model.Requests.RatingsInsertRequest, object>
    {
        public RatingsController(ICRUDService<Ratings, object, RatingsInsertRequest, object> service) : base(service)
        {
        }
    }
}
