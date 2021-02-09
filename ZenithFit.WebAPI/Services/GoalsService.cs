using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.WebAPI.Database;

namespace ZenithFit.WebAPI.Services
{
    public class GoalsService : BaseCRUDService<Model.GoalsChoices, object, Database.GoalsChoices, object, object>
    {
        public GoalsService(ZenithFitDatabaseContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
