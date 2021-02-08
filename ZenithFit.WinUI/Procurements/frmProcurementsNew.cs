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

namespace ZenithFit.WinUI.Procurements
{
    public partial class frmProcurementsNew : Form
    {
        private readonly APIService _serviceSuppliers = new APIService("Suppliers");
        private readonly APIService _serviceWarehouses = new APIService("Warehouses");
        private readonly APIService _serviceArticles = new APIService("Articles");
        private readonly APIService _serviceProcurements = new APIService("Procurements");

        private ProcurementsInsertRequest request = new ProcurementsInsertRequest();

        private decimal amount = 0;
        private const decimal Tax = 0.17M;
        private decimal amountTax = 0;

        public frmProcurementsNew()
        {
            InitializeComponent();
        }

        private async void frmProcurementsNew_Load(object sender, EventArgs e)
        {
            List<Model.Suppliers> suppliers_result = await _serviceSuppliers.Get<List<Model.Suppliers>>(null);

            suppliers_result.Insert(0, new Model.Suppliers());
            cmbSuppliers.DataSource = suppliers_result;
            cmbSuppliers.DisplayMember = "SupplierName";
            cmbSuppliers.ValueMember = "SupplierID";

            List<Model.Warehouses> result_warehouses = await _serviceWarehouses.Get<List<Model.Warehouses>>(null);

            result_warehouses.Insert(0, new Model.Warehouses());
            cmbWarehouses.DataSource = result_warehouses;
            cmbWarehouses.DisplayMember = "WarehouseName";
            cmbWarehouses.ValueMember = "WarehouseID";
        }

        private async void btnAddArticle_Click(object sender, EventArgs e)
        {
            Model.Requests.ArticlesSearchRequest search = new Model.Requests.ArticlesSearchRequest();
            search.ArticleCode = txtArticleCode.Text;
            List<Model.Articles> article = await _serviceArticles.Get<List<Model.Articles>>(search);

            if (article.Count==0)
            {
                MessageBox.Show("An article with that code has not been found");
            }
            else
            {
                bool exists = false;
                Model.Articles art = article.FirstOrDefault();
                foreach (var item in request.Details)
                {
                    if (item.Code == art.ArticleCode)
                    {
                        MessageBox.Show("An article with this code has already been added");
                        exists = true;
                    }
                }

                if(exists == false)
                {
                    ProcurementDetailsInsertRequest details = new ProcurementDetailsInsertRequest();
                    details.ArticleId = art.ArticleID;
                    details.Amount = int.Parse(txtAmount.Text);
                    details.Code = art.ArticleCode;
                    details.Price = art.ArticlePrice;
                    

                    amount += details.Price * details.Amount;
                    amountTax = amount * Tax;

                    txtPrice.Text = Math.Round(amount + amountTax, 2).ToString() + " KM";
                    TxtPriceTax.Text = Math.Round(amountTax, 2).ToString() + " KM";

                    request.Details.Add(details);

                    dgvProcurementArticles.DataSource = request.Details.ToList();
                    
                }
            }
        
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if(request.Details.Count > 0)
            {
                request.ProcurementNumber = txtProcurementNumber.Text;
                request.ProcurementDate = dateTimePicker1.Value;
                request.SupplierId = int.Parse(cmbSuppliers.SelectedValue.ToString());
                request.UserId = 1;
                request.ProcurementNote = txtNotice.Text;
                request.WarehouseId = int.Parse(cmbWarehouses.SelectedValue.ToString());
                request.ProcurementAccountAmount = amount + amountTax;
                request.ProcurementTax = amountTax;

                 await _serviceProcurements.Insert<Model.Procurements>(request);

                MessageBox.Show("Procurement submitted");
                this.Close();
            }

            else
            {
                MessageBox.Show("This action could not be completed due to no articles being added");
            }
        }

        private void txtProcurementNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProcurementNumber.Text))
            { 
                errorProvider.SetError(txtProcurementNumber, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtProcurementNumber, null);
            }
        }

        private void txtNotice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNotice.Text))
            {
                errorProvider.SetError(txtNotice, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNotice, null);
            }
        }

        private void txtArticleCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArticleCode.Text))
            {
                errorProvider.SetError(txtArticleCode, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtArticleCode, null);
            }
        }

        private void txtAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                errorProvider.SetError(txtAmount, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtAmount, null);
            }
        }
    }
}

