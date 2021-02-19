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

namespace ZenithFit.WinUI.Reports
{
    public partial class frmReportsIndex : Form
    {
        private readonly APIService _serviceArticles = new APIService("Articles");
        private readonly APIService _serviceOrders = new APIService("Orders");
        private readonly APIService _serviceOrderDetails = new APIService("OrderDetails");
        private readonly APIService _serviceClients = new APIService("Clients");
        private readonly APIService _serviceComments = new APIService("Comments");
        public frmReportsIndex()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;

        private void button1_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private async void btnArticles_Click(object sender, EventArgs e)
        {

            List<Model.SoldArticles> sold = new List<Model.SoldArticles>();
            List<Model.Articles> articleList = await _serviceArticles.Get<List<Model.Articles>>(null);
            List<Model.OrderDetails> orderList = await _serviceOrderDetails.Get<List<Model.OrderDetails>>(null);

            List<Model.BestSoldArticle> query = await _serviceArticles.GetBestSeller<List<Model.BestSoldArticle>>();
            List<Model.OrderDetails> orders = await _serviceOrderDetails.Get<List<Model.OrderDetails>>(null);
            var returnList = new List<Model.BestSoldArticle>();

            foreach (var artikal in query)
            {
                int TimesOrdered = 0;
                int ArticleSold = 0;
                TimesOrdered = orders.Where(x => x.ArticleId == artikal.ArticleID).Count();
                var listOrders = orders.Where(x => x.ArticleId == artikal.ArticleID).ToList();
                foreach (var item in listOrders)
                {
                    ArticleSold += item.Amount;
                }
                var returnArticle = new Model.BestSoldArticle()
                {
                    OrderedTimes = TimesOrdered,
                    AmountSold = ArticleSold,
                    ArticleCode = artikal.ArticleCode,
                    ArticleID = artikal.ArticleID,
                    ArticleName = artikal.ArticleName,
                    ArticlePrice = artikal.ArticlePrice
                };
                
                returnList.Add(returnArticle);
            }
            returnList = returnList.OrderByDescending(x => x.AmountSold).ToList();
            dataGridView1.DataSource = returnList;

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            List<Model.Articles> articleList = await _serviceArticles.Get<List<Model.Articles>>(null);
            List<Model.Clients> clientList = await _serviceClients.Get<List<Model.Clients>>(null);
            List<Model.Orders> orderList = await _serviceOrders.Get<List<Model.Orders>>(null);
            List<Model.Comments> commentList = await _serviceComments.Get<List<Model.Comments>>(null);
            var returnList = new List<Model.BestClient>();
            foreach(var client in clientList)
            {
                int TimesOrdered = 0;
                int TimesCommented = 0;
                TimesOrdered = orderList.Where(x => x.ClientId == client.ClientId).Count();
                TimesCommented = commentList.Where(x => x.ClientId == client.ClientId).Count();
                var returnclient = new Model.BestClient()
                {
                    Email = client.ClientEmail,
                    FirstName = client.ClientFirstName,
                    LastName = client.ClientLastName,
                    Orders = TimesOrdered,
                    TimesCommented = TimesCommented,
                    Username = client.ClientUsername
                };
                
                returnList.Add(returnclient);
            }
            returnList = returnList.OrderByDescending(x => x.Orders).ToList();
            dataGridView1.DataSource = returnList;
            
        }

        private async void btnOrders_Click(object sender, EventArgs e)
        {
            List<Model.Articles> articleList = await _serviceArticles.Get<List<Model.Articles>>(null);
            List<Model.Comments> commentList = await _serviceComments.Get<List<Model.Comments>>(null);
            var returnList = new List<Model.MostCommentedArticle>();
            foreach(var article in articleList)
            {
                int TimesCommented = 0;
                TimesCommented = commentList.Where(x => x.ArticleId == article.ArticleID).Count();
                var returnArticle = new Model.MostCommentedArticle
                {
                    ArticleID = article.ArticleID,
                    ArticleName = article.ArticleName,
                    Comments = TimesCommented
                };
                returnList.Add(returnArticle);
                    
            }
            returnList = returnList.OrderByDescending(x => x.Comments).ToList();
            dataGridView1.DataSource = returnList;
        }
    }  
}