using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model.Requests;

namespace ZenithFit.WebAPI.Services
{
    public interface IMessagesService
    {
        Model.Messages Insert(MessagesInsertRequest request);
        Model.Messages Update(int id, MessagesInsertRequest request);
        List<Model.Messages> Get(MessagesSearchRequest search);
    }
}
