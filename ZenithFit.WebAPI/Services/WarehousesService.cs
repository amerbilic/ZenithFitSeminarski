using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model.Requests;
using ZenithFit.WebAPI.Database;

namespace ZenithFit.WebAPI.Services
{
    public class WarehousesService : BaseCRUDService<Model.Warehouses, WarehousesSearchRequest, Database.Warehouses, Model.Requests.WarehousesInsertRequest, object>
    {
        public WarehousesService(ZenithFitDatabaseContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Warehouses> Get(WarehousesSearchRequest search)
        {
            var query = _context.Warehouses.AsQueryable();

            if(!string.IsNullOrWhiteSpace(search?.WarehouseName))
            {
                query = query.Where(x => x.WarehouseName.StartsWith(search.WarehouseName));
            }

            if (!string.IsNullOrWhiteSpace(search?.WarehouseAddress))
            {
                query = query.Where(x => x.WarehouseAddress.StartsWith(search.WarehouseAddress));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Warehouses>>(list);

        }


    }
}
