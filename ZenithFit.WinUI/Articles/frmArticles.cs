using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenithFit.Model.Requests;

namespace ZenithFit.WinUI.Articles
{
    public partial class frmArticles : Form
    {
        private readonly APIService _Categories = new APIService("Categories");
        private readonly APIService _Articles = new APIService("Articles");
        private readonly APIService _Manufacturers = new APIService("Manufacturers");


        ArticlesUpsertRequest request = new ArticlesUpsertRequest();

        public frmArticles()
        {
            InitializeComponent();
        }

        private async void frmArticles_Load(object sender, EventArgs e) // calling the load functions on form load
        {
            await LoadCategories();
            await LoadManufacturers();
        }

        private async Task LoadManufacturers() // Loading manufacturers into the cb
        {
            var result = await _Manufacturers.Get<List<Model.Manufacturers>>(null);
            result.Insert(0, new Model.Manufacturers());

            cbManufacturer.DisplayMember = "ManufacturerName";
            cbManufacturer.ValueMember = "ManufacturerID";
            cbManufacturer.DataSource = result;
        }

        private async Task LoadCategories() // Loading Categories into the cb
        {
            var result = await _Categories.Get<List<Model.Categories>>(null);
            result.Insert(0, new Model.Categories());

            cmbArticleCategory.DisplayMember = "CategoryName";
            cmbArticleCategory.ValueMember = "CategoryID";
            cmbArticleCategory.DataSource = result;
        }


        private async void BtnSubmit_Click(object sender, EventArgs e) // Button for submitting the form
        {
           

            var idObjCategory = cmbArticleCategory.SelectedValue;
            var idObjManufacturer = cbManufacturer.SelectedValue;

            if (int.TryParse(idObjCategory.ToString(), out int CategoryId))
            {
                request.CategoryId = CategoryId;
            }

            if (int.TryParse(idObjManufacturer.ToString(), out int ManufacturerId))
            {
                request.ManufacturerId = ManufacturerId;
            }

            request.ArticleName = txtArticleName.Text;
            request.ArticleCode = txtArticleCode.Text;
            request.ArticlePrice = Convert.ToDecimal(txtArticlePrice.Text);
            request.ArticleStatus = true;
            request.ArticlePicture = ImageToByteArray(pbArticles.Image);
            request.ArticlePictureThumb = null;


            await _Articles.Insert<Model.Articles>(request);

        }

        public static byte[] ImageToByteArray(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;

        }


        private void button1_Click(object sender, EventArgs e) //Button for adding images
        {
            var result = openFileDialog1.ShowDialog();

            if(result==DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                request.ArticlePicture = file;
                txtImageInput.Text = fileName;

                Image image = Image.FromFile(fileName);
                pbArticles.Image = image;
                
            }
        }

        private void txtArticleName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArticleName.Text))
            {
                errorProvider.SetError(txtArticleName, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtArticleName, null);
            }
        }

        private void txtArticleCode_Validating(object sender, CancelEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtArticleCode.Text))
            {
                errorProvider.SetError(txtArticleCode, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtArticleCode, null);
            }
        }

        private void txtArticlePrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArticlePrice.Text))
            {
                errorProvider.SetError(txtArticlePrice, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtArticlePrice, null);
            }
        }
    }
}
