using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model.Requests;
using ZenithFit.WebAPI.Database;

namespace ZenithFit.WebAPI.Services
{
    public class OrderDetailsService : BaseCRUDService<Model.OrderDetails, object, Database.OrderDetails, OrderDetailsInsertRequest, object>
    {
        public OrderDetailsService(ZenithFitDatabaseContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
