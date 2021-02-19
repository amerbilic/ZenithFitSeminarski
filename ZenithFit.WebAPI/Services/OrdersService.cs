using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model.Requests;
using ZenithFit.WebAPI.Database;

namespace ZenithFit.WebAPI.Services
{
    public class OrdersService : BaseCRUDService<Model.Orders, OrdersSearchRequest, Database.Orders, OrdersInsertRequest, object>
    {
        public OrdersService(ZenithFitDatabaseContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Orders> Get(OrdersSearchRequest search)
        {
            var query = _context.Orders.AsQueryable();

            if(!string.IsNullOrWhiteSpace(search?.OrderNumber))
            {
                query = query.Where(x => x.OrderNumber.StartsWith(search.OrderNumber));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Orders>>(list);
        }
    }
}
