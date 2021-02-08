using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithFit.WebAPI.Services
{
    public interface IRecommender
    {
        List<Model.Articles> GetSimilarArticles(int ArticleID);
    }
}
