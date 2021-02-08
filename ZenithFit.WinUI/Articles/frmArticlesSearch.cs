using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenithFit.Model.Requests;

namespace ZenithFit.WinUI.Articles
{
    public partial class frmArticlesSearch : Form
    {
        private readonly APIService _Categories = new APIService("Categories");
        private readonly APIService _Articles = new APIService("Articles");
        private readonly APIService _Manufacturers = new APIService("Manufacturers");
        

        public frmArticlesSearch()
        {
            InitializeComponent();
        }

        private async void frmArticlesSearch_Load(object sender, EventArgs e)
        {

            await LoadManufacturers();
            await LoadCategories();
            var articles = await _Articles.Get<List<Model.Articles>>(null);
            dgvArticles.AutoGenerateColumns = false;
            dgvArticles.DataSource = articles;
            
        }

        private async Task LoadManufacturers() // Loading manufacturers into the cb
        {
            var result = await _Manufacturers.Get<List<Model.Manufacturers>>(null);
            result.Insert(0, new Model.Manufacturers());

            cmbArticleManufacturers.DisplayMember = "ManufacturerName";
            cmbArticleManufacturers.ValueMember = "ManufacturerID";
            cmbArticleManufacturers.DataSource = result;
        }

        private async Task LoadCategories() // Loading Categories into the cb
        {
            var result = await _Categories.Get<List<Model.Categories>>(null);
            result.Insert(0, new Model.Categories());

            cmbArticleCategories.DisplayMember = "CategoryName";
            cmbArticleCategories.ValueMember = "CategoryID";
            cmbArticleCategories.DataSource = result;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var request = new ArticlesSearchRequest();
            var ManObjId = cmbArticleManufacturers.SelectedValue;
            var CatObjId = cmbArticleCategories.SelectedValue;
            if (int.TryParse(ManObjId.ToString(), out int manId))
            {
                request.ManufacturerID = manId;
            }

            if (int.TryParse(CatObjId.ToString(), out int CatId))
            {
                request.CategoryID = CatId;
            }

            request.ArticleName = txtArticleName.Text;
            request.ArticleCode = txtArticleCode.Text;
            var result = await _Articles.Get<List<Model.Articles>>(request);
            dgvArticles.DataSource = result;
            

        }


    }
}
