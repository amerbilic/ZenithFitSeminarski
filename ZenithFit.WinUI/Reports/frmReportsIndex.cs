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

        private void btnOrders_Click(object sender, EventArgs e)
        {
            dtpFrom.Enabled = true;
            dtpTo.Enabled = true;
            lbl1.Enabled = true;
            lbl2.Enabled = true;
            txtOrderNo.Enabled = true;
            btnSearch.Enabled = true;
            dataGridView1.DataSource = null;
            txtOrderNo.Text = "";
        }

        private async void btnArticles_Click(object sender, EventArgs e)
        {
            dtpFrom.Enabled = false;
            dtpTo.Enabled = false;
            txtOrderNo.Enabled = false;
            btnSearch.Enabled = false;

            List<Model.SoldArticles> sold = new List<Model.SoldArticles>();
            List<Model.Articles> articleList = await _serviceArticles.Get<List<Model.Articles>>(null);
            List<Model.OrderDetails> orderList = await _serviceOrderDetails.Get<List<Model.OrderDetails>>(null);

            foreach (var item1 in orderList)
            {
                foreach (var item2 in articleList)
                {
                    if (item1.ArticleId == item2.ArticleID)
                    {
                        Model.SoldArticles S1 = new Model.SoldArticles
                        {
                            ArticlePrice = item1.Price,
                            Amount = item1.Amount,
                            ArticleName = item2.ArticleName,
                            ArticleCode = item2.ArticleCode,
                            TotalPrice = item1.Amount * item1.Price
                        };
                        var exists = false;
                        foreach (var item3 in sold)
                        {
                            if (item3.ArticleName.Equals(S1.ArticleName))
                            {
                                exists = true;
                                item3.Amount += S1.Amount;
                                item3.TotalPrice += item3.ArticlePrice * S1.Amount;
                            }
                        }
                        if (exists == false)
                        {
                            sold.Add(S1);
                        }
                    }

                }
            }
            dataGridView1.DataSource = sold;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (dtpFrom.Enabled == true && dtpTo.Enabled == true && txtOrderNo.Enabled == true)
            {
                var search = new OrdersSearchRequest()
                {
                    OrderNumber = txtOrderNo.Text
                };

                var orderList = await _serviceOrders.Get<List<Model.Orders>>(search);
                List<Model.OrdersReport> result = new List<Model.OrdersReport>();

                foreach (var item in orderList)
                {
                    if (dtpFrom.Value < item.OrderDate && item.OrderDate < dtpTo.Value)
                    {
                        result.Add(new Model.OrdersReport
                        {
                            OrderNumber = item.OrderNumber,
                            Date = item.OrderDate,
                            AmountWithNoTax = item.OrderPriceNoTax,
                            AmountWithTax = item.OrderPriceTax
                        });
                    }
                }
                dataGridView1.DataSource = result;
            }
        
    }
    }
    }
