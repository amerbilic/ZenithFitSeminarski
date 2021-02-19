using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model.Requests;
using ZenithFit.WebAPI.Database;

namespace ZenithFit.WebAPI.Services
{
    public class CommentsService : BaseCRUDService<Model.Comments, CommentsSearchRequest, Database.Comments, CommentsInsertRequest, object>
    {
        public CommentsService(ZenithFitDatabaseContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Comments> Get(CommentsSearchRequest search)
        {
            var query = _context.Comments.Include(x=> x.Article).Include(y=>y.Client).AsQueryable();
            if(search.ArticleId != 0)
            {
                query = query.Where(x => x.ArticleId == search.ArticleId);
                
            }
            if(search.ClientId != 0)
            {
                query = query.Where(x => x.ClientId == search.ClientId);
            }
            query = query.OrderByDescending(x => x.CommentDate);
            var list = query.ToList();
            return _mapper.Map<List<Model.Comments>>(list);
        }

    }
}
