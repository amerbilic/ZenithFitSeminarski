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
    public class ProcurementsController : BaseCRUDController<Model.Procurements, ProcurementsSearchRequest, ProcurementsInsertRequest, object>
    {
        public ProcurementsController(ICRUDService<Procurements, ProcurementsSearchRequest, ProcurementsInsertRequest, object> service) : base(service)
        {
        }
    }
}
