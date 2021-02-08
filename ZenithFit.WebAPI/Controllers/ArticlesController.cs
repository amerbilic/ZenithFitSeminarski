using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model;
using ZenithFit.WebAPI.Services;
using ZenithFit.Model.Requests;

namespace ZenithFit.WebAPI.Controllers
{
    public class ArticlesController : BaseCRUDController<Model.Articles, ArticlesSearchRequest, Model.Requests.ArticlesUpsertRequest, Model.Requests.ArticlesUpsertRequest>
    {
        public ArticlesController(ICRUDService<Articles, ArticlesSearchRequest, ArticlesUpsertRequest, ArticlesUpsertRequest> service) : base(service)
        {
        }

    }
}
