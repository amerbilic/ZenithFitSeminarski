
namespace ZenithFit.WinUI.Articles
{
    partial class frmArticles
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
            this.components = new System.ComponentModel.Container();
            this.lblArticleCategory = new System.Windows.Forms.Label();
            this.lblArticleCode = new System.Windows.Forms.Label();
            this.txtArticleCode = new System.Windows.Forms.TextBox();
            this.lblArticleName = new System.Windows.Forms.Label();
            this.txtArticleName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.cmbArticleCategory = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbManufacturer = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtArticlePrice = new System.Windows.Forms.TextBox();
            this.txtImageInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbArticles = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArticleCategory
            // 
            this.lblArticleCategory.AutoSize = true;
            this.lblArticleCategory.Location = new System.Drawing.Point(9, 25);
            this.lblArticleCategory.Name = "lblArticleCategory";
            this.lblArticleCategory.Size = new System.Drawing.Size(80, 13);
            this.lblArticleCategory.TabIndex = 3;
            this.lblArticleCategory.Text = "Article category";
            // 
            // lblArticleCode
            // 
            this.lblArticleCode.AutoSize = true;
            this.lblArticleCode.Location = new System.Drawing.Point(9, 104);
            this.lblArticleCode.Name = "lblArticleCode";
            this.lblArticleCode.Size = new System.Drawing.Size(32, 13);
            this.lblArticleCode.TabIndex = 5;
            this.lblArticleCode.Text = "Code";
            // 
            // txtArticleCode
            // 
            this.txtArticleCode.Location = new System.Drawing.Point(12, 120);
            this.txtArticleCode.Name = "txtArticleCode";
            this.txtArticleCode.Size = new System.Drawing.Size(127, 20);
            this.txtArticleCode.TabIndex = 4;
            this.txtArticleCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtArticleCode_Validating);
            // 
            // lblArticleName
            // 
            this.lblArticleName.AutoSize = true;
            this.lblArticleName.Location = new System.Drawing.Point(9, 65);
            this.lblArticleName.Name = "lblArticleName";
            this.lblArticleName.Size = new System.Drawing.Size(67, 13);
            this.lblArticleName.TabIndex = 7;
            this.lblArticleName.Text = "Article Name";
            // 
            // txtArticleName
            // 
            this.txtArticleName.Location = new System.Drawing.Point(12, 81);
            this.txtArticleName.Name = "txtArticleName";
            this.txtArticleName.Size = new System.Drawing.Size(250, 20);
            this.txtArticleName.TabIndex = 6;
            this.txtArticleName.Validating += new System.ComponentModel.CancelEventHandler(this.txtArticleName_Validating);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(153, 104);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(9, 146);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(70, 13);
            this.lblManufacturer.TabIndex = 12;
            this.lblManufacturer.Text = "Manufacturer";
            // 
            // cmbArticleCategory
            // 
            this.cmbArticleCategory.FormattingEnabled = true;
            this.cmbArticleCategory.Location = new System.Drawing.Point(12, 41);
            this.cmbArticleCategory.Name = "cmbArticleCategory";
            this.cmbArticleCategory.Size = new System.Drawing.Size(250, 21);
            this.cmbArticleCategory.TabIndex = 15;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(290, 204);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 30);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // cbManufacturer
            // 
            this.cbManufacturer.FormattingEnabled = true;
            this.cbManufacturer.Location = new System.Drawing.Point(12, 164);
            this.cbManufacturer.Name = "cbManufacturer";
            this.cbManufacturer.Size = new System.Drawing.Size(250, 21);
            this.cbManufacturer.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtArticlePrice
            // 
            this.txtArticlePrice.Location = new System.Drawing.Point(156, 120);
            this.txtArticlePrice.Name = "txtArticlePrice";
            this.txtArticlePrice.Size = new System.Drawing.Size(106, 20);
            this.txtArticlePrice.TabIndex = 20;
            this.txtArticlePrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtArticlePrice_Validating);
            // 
            // txtImageInput
            // 
            this.txtImageInput.Location = new System.Drawing.Point(12, 211);
            this.txtImageInput.Name = "txtImageInput";
            this.txtImageInput.Size = new System.Drawing.Size(162, 20);
            this.txtImageInput.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Image";
            // 
            // pbArticles
            // 
            this.pbArticles.Location = new System.Drawing.Point(12, 237);
            this.pbArticles.Name = "pbArticles";
            this.pbArticles.Size = new System.Drawing.Size(162, 94);
            this.pbArticles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbArticles.TabIndex = 23;
            this.pbArticles.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 343);
            this.Controls.Add(this.pbArticles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImageInput);
            this.Controls.Add(this.txtArticlePrice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbManufacturer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbArticleCategory);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblArticleName);
            this.Controls.Add(this.txtArticleName);
            this.Controls.Add(this.lblArticleCode);
            this.Controls.Add(this.txtArticleCode);
            this.Controls.Add(this.lblArticleCategory);
            this.Name = "frmArticles";
            this.Text = "frmArticles";
            this.Load += new System.EventHandler(this.frmArticles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblArticleCategory;
        private System.Windows.Forms.Label lblArticleCode;
        private System.Windows.Forms.TextBox txtArticleCode;
        private System.Windows.Forms.Label lblArticleName;
        private System.Windows.Forms.TextBox txtArticleName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.ComboBox cmbArticleCategory;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbManufacturer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtArticlePrice;
        private System.Windows.Forms.TextBox txtImageInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbArticles;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}