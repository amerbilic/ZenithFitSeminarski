using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model;
using ZenithFit.Model.Requests;
using ZenithFit.WebAPI.Database;
using ZenithFit.WebAPI.Services;

namespace ZenithFit.WebAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]

    public class UsersController : ControllerBase
    {
        private readonly IUsersService _service;
        public UsersController(IUsersService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.Users>> Get([FromQuery]UsersSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Model.Users GetbyId(int id)
        {
            return _service.GetbyId(id);
        }

        [Authorize]
        [HttpPost]
        public Model.Users Insert(UsersInsertRequest request)
        {
            return _service.Insert(request);

        }
        [HttpPut("{id}")]
        public Model.Users Update(int id,UsersInsertRequest update)
        {
            return _service.Update(id,update);

        }

        [HttpGet]
        [Route("Authenticiraj/{username},{password}")]
        public Model.Users Authenticate(string username, string password)
        {
            return _service.Authenticate(username, password);
        }

    }
}
