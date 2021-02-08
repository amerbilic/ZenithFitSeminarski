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
    public class ProcurementDetailsController : BaseCRUDController<Model.ProcurementDetails, object, ProcurementDetailsInsertRequest, object>
    {
        public ProcurementDetailsController(ICRUDService<ProcurementDetails, object, ProcurementDetailsInsertRequest, object> service) : base(service)
        {
        }
    }
}
