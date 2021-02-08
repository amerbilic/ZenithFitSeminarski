
namespace ZenithFit.WinUI.Articles
{
    partial class frmArticlesSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.cmbArticleCategories = new System.Windows.Forms.ComboBox();
            this.cmbArticleManufacturers = new System.Windows.Forms.ComboBox();
            this.txtArticleName = new System.Windows.Forms.TextBox();
            this.txtArticleCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ArticleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticlePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticlePicture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticles
            // 
            this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArticleName,
            this.ArticleCode,
            this.ArticlePrice,
            this.ArticlePicture,
            this.ArticleStatus,
            this.ArticleCategory,
            this.ArticleManufacturer});
            this.dgvArticles.Location = new System.Drawing.Point(12, 123);
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.Size = new System.Drawing.Size(776, 261);
            this.dgvArticles.TabIndex = 0;
            // 
            // cmbArticleCategories
            // 
            this.cmbArticleCategories.FormattingEnabled = true;
            this.cmbArticleCategories.Location = new System.Drawing.Point(12, 25);
            this.cmbArticleCategories.Name = "cmbArticleCategories";
            this.cmbArticleCategories.Size = new System.Drawing.Size(207, 21);
            this.cmbArticleCategories.TabIndex = 1;
            // 
            // cmbArticleManufacturers
            // 
            this.cmbArticleManufacturers.FormattingEnabled = true;
            this.cmbArticleManufacturers.Location = new System.Drawing.Point(12, 83);
            this.cmbArticleManufacturers.Name = "cmbArticleManufacturers";
            this.cmbArticleManufacturers.Size = new System.Drawing.Size(207, 21);
            this.cmbArticleManufacturers.TabIndex = 2;
            // 
            // txtArticleName
            // 
            this.txtArticleName.Location = new System.Drawing.Point(243, 25);
            this.txtArticleName.Name = "txtArticleName";
            this.txtArticleName.Size = new System.Drawing.Size(161, 20);
            this.txtArticleName.TabIndex = 3;
            // 
            // txtArticleCode
            // 
            this.txtArticleCode.Location = new System.Drawing.Point(243, 83);
            this.txtArticleCode.Name = "txtArticleCode";
            this.txtArticleCode.Size = new System.Drawing.Size(161, 20);
            this.txtArticleCode.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Manufacturers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Article code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Article name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(450, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ArticleName
            // 
            this.ArticleName.DataPropertyName = "ArticleName";
            this.ArticleName.HeaderText = "Name";
            this.ArticleName.Name = "ArticleName";
            // 
            // ArticleCode
            // 
            this.ArticleCode.DataPropertyName = "ArticleCode";
            this.ArticleCode.HeaderText = "Code";
            this.ArticleCode.Name = "ArticleCode";
            // 
            // ArticlePrice
            // 
            this.ArticlePrice.DataPropertyName = "ArticlePrice";
            this.ArticlePrice.HeaderText = "Price";
            this.ArticlePrice.Name = "ArticlePrice";
            // 
            // ArticlePicture
            // 
            this.ArticlePicture.DataPropertyName = "ArticlePicture";
            this.ArticlePicture.HeaderText = "Picture";
            this.ArticlePicture.Name = "ArticlePicture";
            // 
            // ArticleStatus
            // 
            this.ArticleStatus.DataPropertyName = "ArticleStatus";
            this.ArticleStatus.HeaderText = "Status";
            this.ArticleStatus.Name = "ArticleStatus";
            // 
            // ArticleCategory
            // 
            this.ArticleCategory.DataPropertyName = "CategoryName";
            this.ArticleCategory.HeaderText = "Category";
            this.ArticleCategory.Name = "ArticleCategory";
            // 
            // ArticleManufacturer
            // 
            this.ArticleManufacturer.DataPropertyName = "ManufacturerName";
            this.ArticleManufacturer.HeaderText = "Manufacturer";
            this.ArticleManufacturer.Name = "ArticleManufacturer";
            // 
            // frmArticlesSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 396);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArticleCode);
            this.Controls.Add(this.txtArticleName);
            this.Controls.Add(this.cmbArticleManufacturers);
            this.Controls.Add(this.cmbArticleCategories);
            this.Controls.Add(this.dgvArticles);
            this.Name = "frmArticlesSearch";
            this.Text = "frmArticlesSearch";
            this.Load += new System.EventHandler(this.frmArticlesSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.ComboBox cmbArticleCategories;
        private System.Windows.Forms.ComboBox cmbArticleManufacturers;
        private System.Windows.Forms.TextBox txtArticleName;
        private System.Windows.Forms.TextBox txtArticleCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticlePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticlePicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleManufacturer;
    }
}