using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ZenithFit.Model;
using ZenithFit.Model.Requests;

namespace ZenithFit.MobileApp.ViewModels
{
    public class ArticlesViewModel : BaseViewModel
    {
        private readonly APIService _ArticlesService = new APIService("Articles");
        private readonly APIService _CategoriesService = new APIService("Categories");
        public ArticlesViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Articles> ArticlesList { get; set; } = new ObservableCollection<Articles>();
        public ObservableCollection<Categories> CategoryList { get; set; } = new ObservableCollection<Categories>();

        Categories _SelectedCategory = null;
        public Categories SelectedCategory
        {
            get { return _SelectedCategory; }
            set 
            {
                SetProperty(ref _SelectedCategory, value);
                if(value!=null)
                {
                    InitCommand.Execute(null);
                }
              
            }
        }
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if(CategoryList.Count == 0)
            {
                var categoriesList = await _CategoriesService.Get<List<Categories>>(null);

                foreach (var category in categoriesList)
                {
                    CategoryList.Add(category);
                }
            }

            if(SelectedCategory!=null)
            {
                CategoriesSearchRequest search = new CategoriesSearchRequest();
                search.CategoryID = SelectedCategory.CategoryID;

                var list = await _ArticlesService.Get<IEnumerable<Articles>>(search);

                ArticlesList.Clear();
                foreach (var article in list)
                {
                    ArticlesList.Add(article);
                }
            }
            
        }
    }
}
