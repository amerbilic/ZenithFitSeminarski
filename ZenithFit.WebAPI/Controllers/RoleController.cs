using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.WebAPI.Services;

namespace ZenithFit.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
            private readonly IRolesService _service;

            public RoleController(IRolesService service)
            {
                _service = service;
            }

            [HttpGet]
            public List<Model.Roles> Get()
            {
                return _service.Get();
            }
            [HttpGet]
            [Route("CheckAdmin/{RoleId}")]
            public Model.Roles CheckAdmin(int RoleId)
            {
                return _service.CheckAdmin(RoleId);
            }
        }
}
