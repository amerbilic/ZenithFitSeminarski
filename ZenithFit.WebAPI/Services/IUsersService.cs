using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model.Requests;
using ZenithFit.WebAPI.Database;

namespace ZenithFit.WebAPI.Services
{
    public interface IUsersService
    {
        List<Model.Users> Get(UsersSearchRequest request);

        Model.Users GetbyId(int id);

        Model.Users Insert(UsersInsertRequest request);

        Model.Users Update(int id, UsersInsertRequest update);

        Model.Users Authenticate(UserLoginRequest request);
    }
}
