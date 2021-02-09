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
    public class RecommenderController : ControllerBase
    {
        
            private readonly IRecommender _service;

            public RecommenderController(IRecommender service)
            {
                _service = service;
            }

            [HttpGet]
            [Route("GetSimilarArticles/{ArticleId}")]
            public List<Model.Articles> GetSimilarArticles(int ArticleId)
            {
                return _service.GetSimilarArticles(ArticleId);
            }
        }
}
