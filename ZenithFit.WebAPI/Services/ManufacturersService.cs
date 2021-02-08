using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model.Requests;
using ZenithFit.WebAPI.Database;

namespace ZenithFit.WebAPI.Services
{
    public class ManufacturersService : BaseCRUDService<Model.Manufacturers, object, Database.Manufacturers, ManufacturersInsertRequest, object>
    {
        public ManufacturersService(ZenithFitDatabaseContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
