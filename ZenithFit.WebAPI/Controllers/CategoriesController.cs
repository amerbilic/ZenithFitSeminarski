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

    public class CategoriesController : BaseCRUDController<Model.Categories, object, Model.Requests.CategoriesInsertRequest, object>
    {
        public CategoriesController(ICRUDService<Categories, object, CategoriesInsertRequest, object> service) : base(service)
        {
        }
    }
}
