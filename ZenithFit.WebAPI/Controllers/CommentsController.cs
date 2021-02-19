using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model.Requests;
using ZenithFit.WebAPI.Services;

namespace ZenithFit.WebAPI.Controllers
{
    public class CommentsController : BaseCRUDController<Model.Comments, CommentsSearchRequest,CommentsInsertRequest, object>
    {
        public CommentsController(ICRUDService<Model.Comments, CommentsSearchRequest,CommentsInsertRequest, object> service) : base(service)
        {
        }

    }
}
