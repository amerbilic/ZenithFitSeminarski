using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model;
using ZenithFit.Model.Requests;
using ZenithFit.WebAPI.Database;

namespace ZenithFit.WebAPI.Services
{
    public class MessagesService : IMessagesService
    {
        protected readonly ZenithFitDatabaseContext _context;
        protected readonly IMapper _mapper;
        public MessagesService(ZenithFitDatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Model.Messages> Get(MessagesSearchRequest search)
        {
            var query = _context.Set<Database.Messages>().AsQueryable();
            if (search.CurrentClient != 0)
            {
                query = query.Where(x => (x.ClientId == search.CurrentClient)).OrderBy(x => x.CreatedDate);
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.Messages>>(list);
        }

        public Model.Messages Insert(MessagesInsertRequest request)
        {
            var entity = _mapper.Map<Database.Messages>(request);

            _context.Set<Database.Messages>().Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Messages>(entity);
        }

        public Model.Messages Update(int id, MessagesInsertRequest request)
        {
            var entity = _context.Set<Database.Messages>().Find(id);
            _context.Set<Database.Messages>().Attach(entity);
            _context.Set<Database.Messages>().Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Messages>(entity);
        }
    }
}
