using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithFit.WebAPI.Services
{
    public interface IRolesService
    {
        List<Model.Roles> Get();
        Model.Roles CheckAdmin(int roleId);
    }
}
