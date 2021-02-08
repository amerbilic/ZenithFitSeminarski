using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.WebAPI.Database;

namespace ZenithFit.WebAPI.Services
{
    public class RatingsService : BaseCRUDService<Model.Ratings, object, Database.Ratings, Model.Requests.RatingsInsertRequest, object>
    {
        public RatingsService(ZenithFitDatabaseContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
