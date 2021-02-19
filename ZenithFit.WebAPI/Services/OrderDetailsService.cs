using AutoMapper;
using Microsoft.EntityFrameworkCore;
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

        public override List<Model.OrderDetails> Get(object search)
        {
            var query = _context.OrderDetails.Include(y => y.Article).AsQueryable();
            var list = query.ToList();

            return _mapper.Map<List<Model.OrderDetails>>(list);
        }
    }
}
