using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model.Requests;
using ZenithFit.WebAPI.Database;

namespace ZenithFit.WebAPI.Services
{
    public class ProcurementDetailsService : BaseCRUDService<Model.ProcurementDetails, object, Database.Procurements, ProcurementDetailsInsertRequest, object>
    {
        public ProcurementDetailsService(ZenithFitDatabaseContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
