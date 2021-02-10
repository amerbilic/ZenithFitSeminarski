using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model;
using ZenithFit.WebAPI.Database;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ZenithFit.WebAPI.Services
{
    public class RecommenderService : IRecommender
    {
        Dictionary<int, List<Model.Ratings>> articles = new Dictionary<int, List<Model.Ratings>>();
        private readonly ZenithFitDatabaseContext _context;
        private readonly IMapper _mapper;

        public RecommenderService(ZenithFitDatabaseContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        public List<Model.Articles> GetSimilarArticles(int ArticleId)
        {
            LoadArticles(ArticleId);

            List<Model.Ratings> ObservedArticleRatings = new List<Model.Ratings>();
            List<Database.Ratings> recordedratings = _context.Ratings.Where(x => x.ArticleId == ArticleId).OrderBy(x => x.ClientId).ToList();
            _mapper.Map(recordedratings, ObservedArticleRatings);

            List<Model.Ratings> CompoundRatings1 = new List<Model.Ratings>();
            List<Model.Ratings> CompoundRatings2 = new List<Model.Ratings>();
            List<Model.Articles> recommendedArticles = new List<Model.Articles>();

            foreach(var item in articles)
            {
                foreach(Model.Ratings r in ObservedArticleRatings)
                {
                    if(item.Value.Where(x=>x.ClientID == r.ClientID).Count() > 0 )
                    {
                        CompoundRatings1.Add(r);
                        CompoundRatings2.Add(item.Value.Where(x => x.ClientID == r.ClientID).First());
                    }
                }
                double similarities = 0;
                similarities = GetSimilarities(CompoundRatings1, CompoundRatings2);

                if(similarities>0.89)
                {
                    Database.Articles element1 = _context.Articles.Include(x => x.Manufacturer).Include(x=>x.Category).Where(x => x.ArticleId == item.Key).FirstOrDefault();
                    Model.Articles element2 = new Model.Articles();

                    element2.ManufacturerName = element1.Manufacturer.ManufacturerName;
                    element2.ArticlePrice = element1.ArticlePrice;
                    element2.ArticleID = element1.ArticleId;
                    element2.ArticleName = element1.ArticleName;
                    element2.CategoryName = element1.Category.CategoryName;
                    element2.CategoryId = element1.CategoryId;
                    element2.ArticleCode = element1.ArticleCode;
                    element2.ArticlePicture = element1.ArticlePicture;
                    element2.ArticlePictureThumb = element1.ArticlePictureThumb;
                    element2.ArticleStatus = element1.ArticleStatus;
                    element1.ManufacturerId = element2.ManufacturerId;

                    recommendedArticles.Add(element2);

                }
                CompoundRatings1.Clear();
                CompoundRatings2.Clear();
            }
            return recommendedArticles;

        }

        private double GetSimilarities(List<Model.Ratings> compoundRatings1,List<Model.Ratings> compoundRatings2)
        {
            if (compoundRatings1.Count != compoundRatings2.Count)
                return 0;

            double num1 = 0, num2 = 0, num3 = 0;

            for (int i=0;i<compoundRatings1.Count; i++)
            {
                num1 += compoundRatings1[i].RatingGrade * compoundRatings2[i].RatingGrade;
                num2 += compoundRatings1[i].RatingGrade * compoundRatings1[i].RatingGrade;
                num3 += compoundRatings2[i].RatingGrade * compoundRatings2[i].RatingGrade;
            }

            num2 = Math.Sqrt(num2);
            num3 = Math.Sqrt(num3);
            double number = num2 * num3;
            if (number == 0)
                return 0;
            return num1 / number;
        }

        private void LoadArticles(int articleID)
        {
            List<Database.Articles> activeArticles = _context.Articles.Include(x => x.Manufacturer).Where(x => x.ArticleId != articleID).ToList();

            Database.Articles ObservedArticle = _context.Articles.Where(x => x.ArticleId == articleID).SingleOrDefault();

            List<Model.Articles> newlist = new List<Model.Articles>();
            _mapper.Map(activeArticles, newlist);

            List<Model.Articles> resultlist = new List<Model.Articles>();
            foreach(var item in newlist)
            {
                if(item.ManufacturerId == ObservedArticle.ManufacturerId)
                {
                    resultlist.Add(item);
                }
            }

            foreach(Model.Articles a in resultlist)
            {
                List<Database.Ratings> ratinglist = _context.Ratings.Where(x => x.ArticleId == a.ArticleID).ToList();
                List<Model.Ratings> ratings = new List<Model.Ratings>();
                foreach(var item in ratinglist)
                {
                    Model.Ratings newrating = new Model.Ratings();
                    newrating.RatingDate = item.RatingDate;
                    newrating.RatingGrade = item.RatingGrade;
                    newrating.ArticleID = item.ArticleId;
                    newrating.ClientID = item.ClientId;
                    newrating.RatingID = item.RatingId;

                    ratings.Add(newrating);
                }
                if (ratings.Count > 0)
                    articles.Add(a.ArticleID, ratings);
            }
        }
    }
}
