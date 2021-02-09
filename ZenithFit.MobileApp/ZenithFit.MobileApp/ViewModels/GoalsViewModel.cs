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
    public class GoalsViewModel : BaseViewModel
    {
        private readonly APIService _ArticlesService = new APIService("Articles");
        private readonly APIService _GoalsService = new APIService("GoalsChoices");
        public GoalsViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Articles> ArticlesList { get; set; } = new ObservableCollection<Articles>();
        public ObservableCollection<GoalsChoices> GoalsList { get; set; } = new ObservableCollection<GoalsChoices>();

        GoalsChoices _SelectedGoal = null;
        public GoalsChoices SelectedGoal
        {
            get { return _SelectedGoal; }
            set
            {
                SetProperty(ref _SelectedGoal, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if (GoalsList.Count == 0)
            {
                var goalList = await _GoalsService.Get<List<GoalsChoices>>(null);
                

                foreach (var goal in goalList)
                {
                    GoalsList.Add(goal);
                }
            }

            if (SelectedGoal != null)
            {
                if (SelectedGoal.GoalName == "Bulking")
                {
                    var arlist = await _ArticlesService.Get<List<Articles>>(null);
                    ArticlesList.Clear();
                    foreach(var check in arlist)
                    {
                        if(check.CategoryName == "Proteini" || check.CategoryName== "WeightGainer")
                        {
                            ArticlesList.Add(check);
                        }
                    }

                }
                else if(SelectedGoal.GoalName == "Muscle Building")
                {
                    var arlist = await _ArticlesService.Get<List<Articles>>(null);
                    ArticlesList.Clear();
                    foreach (var check in arlist)
                    {
                        if (check.CategoryName == "Proteini")
                        {
                            ArticlesList.Add(check);
                        }
                    }
                }

                else if(SelectedGoal.GoalName == "Fat Burning")
                {
                    var arlist = await _ArticlesService.Get<List<Articles>>(null);
                    ArticlesList.Clear();
                    foreach (var check in arlist)
                    {
                        if (check.CategoryName == "Pre-workout" || check.CategoryName == "Fat-burner")
                        {
                            ArticlesList.Add(check);
                        }
                    }
                }

            }

        }
    }
}