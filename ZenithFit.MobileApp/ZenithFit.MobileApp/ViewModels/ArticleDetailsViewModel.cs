using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ZenithFit.Model;

namespace ZenithFit.MobileApp.ViewModels
{
    public class ArticleDetailsViewModel : BaseViewModel
    {
        private readonly APIService _ArticleService = new APIService("Articles");
        private readonly APIService _RatingsService = new APIService("Ratings");
        private readonly APIService _RecommenderService = new APIService("Recommender");

        public ArticleDetailsViewModel()
        {
            IncreaseQuantityCommand = new Command(() => Quantity += 1);
            DecreaseQuantityCommand = new Command(() => { if (Quantity > 0) { Quantity -= 1; } });
            OrderCommand = new Command(Order);
            RateWith1Command = new Command(async () => await Rate(1));
            RateWith2Command = new Command(async () => await Rate(2));
            RateWith3Command = new Command(async () => await Rate(3));
            RateWith4Command = new Command(async () => await Rate(4));
            RateWith5Command = new Command(async () => await Rate(5));
            RecommenderCommand = new Command(async () => await Recommender());
        }

        public Articles Article { get; set; }
        public ObservableCollection<Ratings> ArticleRatingsList { get; set; } = new ObservableCollection<Ratings>();
        public ObservableCollection<Articles> ArticleList { get; set; } = new ObservableCollection<Articles>();
        public ObservableCollection<Articles> RecommenderList { get; set; } = new ObservableCollection<Articles>();

        decimal _quantity = 0;
        public decimal Quantity
        {
            get { return _quantity; }
            set { SetProperty(ref _quantity, value); }
        }

        double _AverageRating;
        public double AverageRating
        {
            get { return _AverageRating; }
            set { SetProperty(ref _AverageRating, value); }
        }

        bool _Rated;
        public bool Rated
        {
            get { return _Rated; }
            set { SetProperty(ref _Rated, value); }
        }
        bool _NotRated;
        public bool NotRated
        {
            get { return _NotRated; }
            set { SetProperty(ref _NotRated, value); }
        }
        
        public async Task Recommender()
        {
            RecommenderList.Clear();
            List<Articles> articlelist = new List<Articles>();
            articlelist = await _RecommenderService.GetSimilarArticles<List<Articles>>(Article.ArticleID);

            List<Ratings> ratinglist = new List<Ratings>();
            ratinglist = await _RatingsService.Get<List<Ratings>>(null);

            foreach(var item in articlelist)
            {
                int total = 0;
                decimal amount = 0;

                foreach(var item2 in ratinglist)
                {
                    if(item2.ArticleID == item.ArticleID)
                    {
                        amount += item2.Rating;
                        total++;
                    }
                }

                item.AveragePrice = amount / total;

                RecommenderList.Add(item);
            }
        }
        public async Task Init()
        {
            var Ratinglist = await _RatingsService.Get<List<Model.Ratings>>(null);
            Rated = false;
            foreach(var item in Ratinglist)
            {
                if(item.ArticleID == Article.ArticleID)
                {
                    ArticleRatingsList.Add(item);
                    if (item.ClientID == LoggedInUser.ActiveClient.ClientId)
                    {
                        Rated = true;
                    }
                }
            }

            NotRated = !Rated;
            if(ArticleRatingsList.Count() != 0)
            {
                AverageRating = ArticleRatingsList.Select(s => s.Rating).Average();
            }
            else
            {
                AverageRating = 0;
            }

        }

        public async Task Rate(int rating)
        {
            Model.Requests.RatingsInsertRequest x = new Model.Requests.RatingsInsertRequest
            {
                ArticleID = Article.ArticleID,
                ClientID = LoggedInUser.ActiveClient.ClientId,
                Rating = rating,
                RatingDate = DateTime.Now
            };

            await _RatingsService.Insert<Model.Ratings>(x);
            Rated = true;
            NotRated = false;
            await App.Current.MainPage.DisplayAlert("Successfuly rated", "", "OK");
            
        }

        public ICommand IncreaseQuantityCommand { get; set; }
        public ICommand DecreaseQuantityCommand { get; set; }
        public ICommand OrderCommand { get; set; }
        public ICommand RateWith1Command { get; set; }
        public ICommand RateWith2Command { get; set; }
        public ICommand RateWith3Command { get; set; }
        public ICommand RateWith4Command { get; set; }
        public ICommand RateWith5Command { get; set; }

        public ICommand RecommenderCommand { get; set; }

        private void Order()
        {
            if (Quantity > 0)
            {
                if (CartService.Cart.ContainsKey(Article.ArticleID))
                {
                    CartService.Cart.Remove(Article.ArticleID);
                }
                CartService.Cart.Add(Article.ArticleID, this);
            }
            else
            {
                App.Current.MainPage.DisplayAlert("The quantity can not be zero", "", "OK");
            }
        }
    }
}
