using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model;
using ZenithFit.Model.Requests;
using ZenithFit.WebAPI.Services;

namespace ZenithFit.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService _service;
        public ClientsController(IClientService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Clients> Get([FromQuery]ClientsSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Clients GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet]
        [Route("Authenticate/{username},{password}")]
        public Clients Authenticate(string username, string password)
        {
            return _service.Authenticate(username, password);
        }

        [HttpPost]
        public void Insert(ClientsInsertRequest request)
        {
            _service.Insert(request);
        }

        [HttpPut("{id}")]
        public void Update(int id,[FromBody]ClientsInsertRequest request)
        {
            _service.Update(id, request);
        }
    }
    
}
