using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model;
using ZenithFit.Model.Requests;

namespace ZenithFit.WebAPI.Services
{
    public interface IArticlesService : ICRUDService<Model.Articles, ArticlesSearchRequest, Model.Requests.ArticlesUpsertRequest, ArticlesUpsertRequest>
    {
         List<Model.BestSoldArticle> GetBestSellers();
    }
}
