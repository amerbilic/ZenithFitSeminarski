using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model.Requests;
using ZenithFit.WebAPI.Services;

namespace ZenithFit.WebAPI.Controllers
{

        [Route("api/[controller]")]
        [ApiController]
        public class MessagesController : ControllerBase
        {
            private readonly IMessagesService _service;

            public MessagesController(IMessagesService service)
            {
                _service = service;
            }
            [HttpPost]
            public Model.Messages Insert(MessagesInsertRequest request)
            {
                return _service.Insert(request);
            }
            [HttpPut("{id}")]
            public Model.Messages Update(int id, [FromBody] MessagesInsertRequest request)
            {
                return _service.Update(id, request);
            }
            [HttpGet]
            public List<Model.Messages> Get([FromQuery] MessagesSearchRequest search)
            {
                return _service.Get(search);
            }
        }
    }