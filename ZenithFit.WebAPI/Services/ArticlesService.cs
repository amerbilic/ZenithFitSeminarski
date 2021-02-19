using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model;
using ZenithFit.Model.Requests;
using ZenithFit.WebAPI.Database;

namespace ZenithFit.WebAPI.Services
{
    public class ArticlesService : BaseCRUDService<Model.Articles, ArticlesSearchRequest, Database.Articles, Model.Requests.ArticlesUpsertRequest, ArticlesUpsertRequest>, IArticlesService
    {
        public ArticlesService(ZenithFitDatabaseContext context, IMapper mapper) : base(context, mapper)
        { }

        public override List<Model.Articles> Get(ArticlesSearchRequest search)
        {
            var query = _context.Articles.Include(y => y.Manufacturer).Include(z => z.Category).AsQueryable();


            if (search?.CategoryID.HasValue == true)
            {
                query = query.Where(x => x.CategoryId == search.CategoryID);

            }

            if (search?.ManufacturerID.HasValue == true)
            {
                query = query.Where(x => x.ManufacturerId == search.ManufacturerID);

            }
            if (!string.IsNullOrWhiteSpace(search?.ArticleName))
            {
                query = query.Where(x => x.ArticleName.StartsWith(search.ArticleName));
            }
            if (!string.IsNullOrWhiteSpace(search?.ArticleCode))
            {
                query = query.Where(x => x.ArticleCode == search.ArticleCode);
            }

            query = query.OrderBy(x => x.ArticleName);

            var list = query.ToList();

            List<Model.Articles> arlist = new List<Model.Articles>();

            foreach (var item in list)
            {
                Model.Articles newitem = new Model.Articles();

                newitem.ArticleID = item.ArticleId;
                newitem.ArticleCode = item.ArticleCode;
                newitem.ArticleName = item.ArticleName;
                newitem.ArticlePicture = item.ArticlePicture;
                newitem.ArticlePictureThumb = item.ArticlePictureThumb;
                newitem.ArticlePrice = item.ArticlePrice;
                newitem.ArticleStatus = item.ArticleStatus;
                newitem.ManufacturerId = item.ManufacturerId;
                newitem.CategoryId = item.CategoryId;
                newitem.CategoryName = item.Category.CategoryName;
                newitem.ManufacturerName = item.Manufacturer.ManufacturerName;

                arlist.Add(newitem);
            }


            return arlist;
        }

        public List<Model.BestSoldArticle> GetBestSellers()
        {
            var query = _context.Articles.Include(y => y.Manufacturer).Include(z => z.Category).AsQueryable();
            var orders = _context.Set<Database.OrderDetails>().AsQueryable();
            var returnList = new List<Model.BestSoldArticle>();

            foreach (var artikal in query)
            {
                int TimesOrdered = 3;
                int ArticleSold = 5;
                TimesOrdered = orders.Where(x => x.ArticleId == artikal.ArticleId).Count();
                var listOrders = orders.Where(x => x.ArticleId == artikal.ArticleId).ToList();
                foreach(var item in listOrders)
                {
                    ArticleSold += item.Amount;
                }
                var returnArticle = new Model.BestSoldArticle()
                {
                    OrderedTimes = TimesOrdered,
                    AmountSold = ArticleSold,
                    ArticleCode = artikal.ArticleCode,
                    ArticleID = artikal.ArticleId,
                    ArticleName = artikal.ArticleName,
                    ArticlePrice = artikal.ArticlePrice
                };
                returnList.Add(returnArticle);
            }

            return returnList;
        }
    }
}

