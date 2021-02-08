using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model;
using ZenithFit.Model.Requests;

namespace ZenithFit.WebAPI.Services
{
    public interface IClientService
    {
        List<Clients> Get(ClientsSearchRequest search);
        Clients GetById(int id);
        void Insert(ClientsInsertRequest request);

        void Update(int id, ClientsInsertRequest request);

        Clients Authenticate(string username, string password);
    }
}
