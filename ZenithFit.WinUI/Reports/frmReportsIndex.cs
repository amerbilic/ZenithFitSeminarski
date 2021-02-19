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
                returnList = returnList.OrderByDescending(x => x.AmountSold).ToList();
                returnList.Add(returnArticle);
            }
            dataGridView1.DataSource = returnList;

        }
    }  
}