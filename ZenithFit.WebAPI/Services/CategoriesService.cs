using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.WebAPI.Database;

namespace ZenithFit.WebAPI.Services
{
    public class CategoriesService : BaseCRUDService<Model.Categories, object, Database.Categories, Model.Requests.CategoriesInsertRequest, object>
    {
        public CategoriesService(ZenithFitDatabaseContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
