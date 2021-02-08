using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model.Requests;
using ZenithFit.WebAPI.Database;

namespace ZenithFit.WebAPI.Services
{
    public class SuppliersService : BaseCRUDService<Model.Suppliers, SuppliersSearchRequest, Database.Suppliers, SuppliersUpsertRequest, SuppliersUpsertRequest>
    {
        public SuppliersService(ZenithFitDatabaseContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Suppliers> Get(SuppliersSearchRequest search)
        {
            var query = _context.Suppliers.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.SupplierName))
            {
                query = query.Where(x => x.SupplierName.StartsWith(search.SupplierName));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Suppliers>>(list);
        }

    }
}
