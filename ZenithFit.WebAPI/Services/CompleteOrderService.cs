using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model.Requests;
using ZenithFit.WebAPI.Database;

namespace ZenithFit.WebAPI.Services
{
    public class CompleteOrderService : BaseCRUDService<Model.CompleteOrder, object, Database.CompleteOrder, CompleteOrderInsertRequest, CompleteOrderUpdateRequest>
    {
        public CompleteOrderService(ZenithFitDatabaseContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
